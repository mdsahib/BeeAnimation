using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BeeAnim
{
    public partial class FormOfFlower : Form , Bee
    {
        // aah , you are the famous bee ;)
        private BeeController bee;
        
        //it is the form of bee'shome
        private BeeForm BeeHouse;

        // the point in which bee will fly to the BeeHouse
        private Point BeesTransitionPoint = new Point(0,0);

        //
        private bool directionToTransitionPoint = false;

        //tiemr to increase the size of the flower
        private System.Windows.Forms.Timer flowerTimer = new System.Windows.Forms.Timer();
        
        //if change the value of this change the value also in setFlower() methods
        public int flowersLife = 2;

        public FormOfFlower(BeeForm BeeHouse)
        {
            Initialize(BeeHouse);
            
        }//end of public FormOfFlower(BeeForm BeeHouse)



        // Let's initialize form
        private void Initialize(BeeForm BeeHouse)
        {
            InitializeComponent();
            this.BeeHouse = BeeHouse;

        }// private void Initialize(BeeForm BeeHouse)



        //Move the bee towaards flower
        public void MoveTowardsFlower()
        {
            //Uuups!!! no bee , lets create one :)
            
            if (bee == null)
            {

                bee = new BeeController(this)
                {
                    location = new Point(0, 0),
                    destination = this.FlowePictureBox.Location
                };


                Controls.Add(bee);
                
                setFlowerTimer();
            }//if (bee == null)


        }


        //change the size of the flower
        private void setFlowerTimer()
        {
            if (flowersLife == 2)
            {
                flowerTimer.Interval = 200;
                flowerTimer.Start();
                flowerTimer.Tick += new EventHandler(flowerTimer_Tick);
            }
            else 
            {
                try
                {
                    flowerTimer.Stop();
                    flowerTimer = null;
                }

                catch (Exception ex)
                { 
                }
            }
            
        }

        void flowerTimer_Tick(object sender, EventArgs e)
        {
            FlowePictureBox.Height += 1;
            FlowePictureBox.Width += 2;
            

        }//private void changeFlower()

        
        
        public void ChangeBeeState()
        {
            //it has reached to the flower now it needs to be reveresed
            if (!directionToTransitionPoint)
            {
                bee.timer.Stop();
                Thread.Sleep(new TimeSpan (0,0,1));
                bee.timer.Start();
                flowersLife--;
                setFlowerTimer();
                if (flowersLife == 0)
                    MessageBox.Show("Flower is dead");
                this.bee.destination = BeesTransitionPoint;
                directionToTransitionPoint = !directionToTransitionPoint;
            }

            else
            {

                this.Controls.Remove(bee);
                this.bee.Dispose();
                bee = null;
                BeeHouse.SetDestinationToHome();
                directionToTransitionPoint = !directionToTransitionPoint;
                
            }
        }

    }//end of class

}//end of namespace

        

