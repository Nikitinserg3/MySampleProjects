namespace MikesNavigator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.labelForTextbox = new System.Windows.Forms.Label();
            this.labelForNumer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(87, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(87, 111);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 92);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Do it, Beach!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // labelForTextbox
            // 
            this.labelForTextbox.AutoSize = true;
            this.labelForTextbox.Location = new System.Drawing.Point(25, 15);
            this.labelForTextbox.Name = "labelForTextbox";
            this.labelForTextbox.Size = new System.Drawing.Size(47, 13);
            this.labelForTextbox.TabIndex = 3;
            this.labelForTextbox.Text = "Say this:";
            // 
            // labelForNumer
            // 
            this.labelForNumer.AutoSize = true;
            this.labelForNumer.Location = new System.Drawing.Point(25, 40);
            this.labelForNumer.Name = "labelForNumer";
            this.labelForNumer.Size = new System.Drawing.Size(56, 13);
            this.labelForNumer.TabIndex = 4;
            this.labelForNumer.Text = "# of times:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelForNumer);
            this.Controls.Add(this.labelForTextbox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Talker App";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label labelForTextbox;
        private System.Windows.Forms.Label labelForNumer;
    }
}

