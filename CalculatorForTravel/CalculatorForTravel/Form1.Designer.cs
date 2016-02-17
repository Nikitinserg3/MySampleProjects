namespace CalculatorForTravel
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
            this.startMileage = new System.Windows.Forms.NumericUpDown();
            this.endMileage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // startMileage
            // 
            this.startMileage.Location = new System.Drawing.Point(124, 14);
            this.startMileage.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.startMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startMileage.Name = "startMileage";
            this.startMileage.Size = new System.Drawing.Size(120, 20);
            this.startMileage.TabIndex = 0;
            this.startMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endMileage
            // 
            this.endMileage.Location = new System.Drawing.Point(124, 63);
            this.endMileage.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.endMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endMileage.Name = "endMileage";
            this.endMileage.Size = new System.Drawing.Size(120, 20);
            this.endMileage.TabIndex = 1;
            this.endMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Starting Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ending Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Owed";
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(121, 119);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(98, 17);
            this.totalAmountLabel.TabIndex = 5;
            this.totalAmountLabel.Text = "The result is...";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(124, 181);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 58);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 261);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endMileage);
            this.Controls.Add(this.startMileage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.startMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown startMileage;
        private System.Windows.Forms.NumericUpDown endMileage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

