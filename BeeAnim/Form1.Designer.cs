namespace BeeAnim
{
    partial class BeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxBeeHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeeHome)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make Bee Out of Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxBeeHome
            // 
            this.pictureBoxBeeHome.Image = global::BeeAnim.Properties.Resources.Hive;
            this.pictureBoxBeeHome.Location = new System.Drawing.Point(27, 91);
            this.pictureBoxBeeHome.Name = "pictureBoxBeeHome";
            this.pictureBoxBeeHome.Size = new System.Drawing.Size(100, 127);
            this.pictureBoxBeeHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBeeHome.TabIndex = 0;
            this.pictureBoxBeeHome.TabStop = false;
            // 
            // BeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxBeeHome);
            this.Name = "BeeForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeeHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBeeHome;
        private System.Windows.Forms.Button button1;
    }
}

