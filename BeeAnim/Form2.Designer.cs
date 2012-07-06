namespace BeeAnim
{
    partial class FormOfFlower
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
            this.FlowePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FlowePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowePictureBox
            // 
            this.FlowePictureBox.Image = global::BeeAnim.Properties.Resources.Flower;
            this.FlowePictureBox.Location = new System.Drawing.Point(165, 184);
            this.FlowePictureBox.Name = "FlowePictureBox";
            this.FlowePictureBox.Size = new System.Drawing.Size(35, 43);
            this.FlowePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlowePictureBox.TabIndex = 2;
            this.FlowePictureBox.TabStop = false;
            // 
            // FormOfFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 365);
            this.Controls.Add(this.FlowePictureBox);
            this.Name = "FormOfFlower";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.FlowePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FlowePictureBox;


    }
}