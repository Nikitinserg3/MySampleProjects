namespace First_Decktop_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.changeText = new System.Windows.Forms.Button();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.labelText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(22, 12);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(161, 23);
            this.changeText.TabIndex = 0;
            this.changeText.Text = "Change the label if checked";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.changeText_Click);
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enableCheckBox.Location = new System.Drawing.Point(339, 18);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(126, 17);
            this.enableCheckBox.TabIndex = 1;
            this.enableCheckBox.Text = "Enable text changing";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelText
            // 
            this.labelText.Location = new System.Drawing.Point(22, 53);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(443, 23);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Press the button to change my text";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.enableCheckBox);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "My Desktop App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

