using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace BeeAnim
{
    class BeeController :PictureBox
    {
        private int picNo;
        public Point location;
        public Point destination;
        public Timer timer;
        private const int moverate = 3;
        // it will become true if bee has reached at his destinaiton
        private bool atHome = false;

        //preserves the reference of the flowerForm
        private Bee form;
        
        public BeeController()
        {
            Initialize();
        }


        public BeeController(Bee Form)
        {
            this.form= Form;
            Initialize();
        }


        public void Initialize()
        {
            picNo = 0;
            BackgroundImageLayout = ImageLayout.Zoom;
            Width = 50;
            Height = 40;
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 150;

            timer.Start();
            timer.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            picNo++;
            switch (picNo)
            {
                case 1:
                    BackgroundImage = Properties.Resources.Bee_animation_1;
                    break;
                case 2:
                    BackgroundImage = Properties.Resources.Bee_animation_2;
                    break;
                case 3: 
                    BackgroundImage = Properties.Resources.Bee_animation_3;
                    break;
                case 4:
                    BackgroundImage = Properties.Resources.Bee_animation_4;
                    picNo = 0;
                    break;
            }
            Location = location;
            BringToFront();
            MoveTowardsDestination();
        }

        public void MoveTowardsDestination()
        {
            if (Math.Abs(destination.X - Location.X) <= moverate && Math.Abs(destination.Y - Location.Y) <= moverate)
            {
                //timer.Enabled = false;
                //timer.Stop();
                BackgroundImage = Properties.Resources.Bee_animation_1;
                atHome = true;
                this.form.ChangeBeeState();

            }
            else
            {
                if (destination.X > Location.X)
                    location.X += moverate;
                else if (destination.X < Location.X)
                    location.X -= moverate;
                if (destination.Y > Location.Y)
                    location.Y += moverate;
                else if(destination.Y < Location.Y)
                    location.Y -= moverate;
            }
        }

        protected override void Dispose(bool disposing)
        {
            timer.Enabled = false;
            timer.Stop();
        }


        // returns true if bee has reached its destination
        public bool isAtHome()
        {
            return atHome;

        } //public bool isAtHome () 

        public FormOfFlower flowerFrom { get; set; }
    }
}
