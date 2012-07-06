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
    public partial class BeeForm : Form , Bee
    {
        private BeeController bee = null;
        
        //This form contains the flower
        private FormOfFlower FlowerForm;

        //point to whihc bee will move in the way to flower
        private Point BeesTransitionPoint;

        //
        private bool directionToTransitionPoint = true;
        
        public BeeForm()
        {
            Initialze();
        }


        //Initilize the Form 
        private void Initialze()
        {

            InitializeComponent();
            BeesTransitionPoint = new Point(this.Width - 20, 0);
            FlowerForm = new FormOfFlower(this);
            FlowerForm.Show();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (bee == null)
            {
                bee = new BeeController(this)
                {
                    location = this.pictureBoxBeeHome.Location,
                    destination = this.BeesTransitionPoint
                    
                };
                
                Controls.Add(bee);
                Controls.Remove((Button)sender);
            }
            
        }

        
        //Move the bee towards it's home when it 
        //files in from the FormOfflower

        public void SetDestinationToHome()
        {
            

                bee = new BeeController(this)
                {
                    location = this.BeesTransitionPoint,
                    destination = this.pictureBoxBeeHome.Location
                };

                Controls.Add(bee);


        }//end of MoveTowardsHome


        public void ChangeBeeState()
        {
            //it is going to the transition point and needs to be disposed
            if (directionToTransitionPoint)
            {
                
                Controls.Remove(bee);
                bee.timer.Stop();
                bee.Dispose();
                bee = null;
                FlowerForm.MoveTowardsFlower();
                directionToTransitionPoint = !directionToTransitionPoint;
            }

            else
            {
                
                if (FlowerForm.flowersLife>0)
                {
                    bee.timer.Stop();
                    Thread.Sleep(new TimeSpan(0, 0, 1));
                    bee.timer.Start();
                    this.bee.destination = this.BeesTransitionPoint;
                    directionToTransitionPoint = !directionToTransitionPoint;
                }
            }
        }
    
    
    }//end of class declaration



}// end of Namespace
