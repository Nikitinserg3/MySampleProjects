namespace BeeHiveApp
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
            this.workerbeeJob = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.assignJobButton = new System.Windows.Forms.Button();
            this.nextShiftButton = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerbeeJob
            // 
            this.workerbeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerbeeJob.FormattingEnabled = true;
            this.workerbeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufactoring",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerbeeJob.Location = new System.Drawing.Point(31, 56);
            this.workerbeeJob.Name = "workerbeeJob";
            this.workerbeeJob.Size = new System.Drawing.Size(225, 21);
            this.workerbeeJob.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(262, 56);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(101, 20);
            this.shifts.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shifts";
            // 
            // assignJobButton
            // 
            this.assignJobButton.Location = new System.Drawing.Point(31, 83);
            this.assignJobButton.Name = "assignJobButton";
            this.assignJobButton.Size = new System.Drawing.Size(332, 32);
            this.assignJobButton.TabIndex = 5;
            this.assignJobButton.Text = "Assign this job to a bee";
            this.assignJobButton.UseVisualStyleBackColor = true;
            this.assignJobButton.Click += new System.EventHandler(this.assignJobButton_Click);
            // 
            // nextShiftButton
            // 
            this.nextShiftButton.Location = new System.Drawing.Point(388, 12);
            this.nextShiftButton.Name = "nextShiftButton";
            this.nextShiftButton.Size = new System.Drawing.Size(178, 116);
            this.nextShiftButton.TabIndex = 6;
            this.nextShiftButton.Text = "Work the next shift";
            this.nextShiftButton.UseVisualStyleBackColor = true;
            this.nextShiftButton.Click += new System.EventHandler(this.nextShiftButton_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 147);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(554, 260);
            this.report.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 419);
            this.Controls.Add(this.report);
            this.Controls.Add(this.nextShiftButton);
            this.Controls.Add(this.assignJobButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shifts);
            this.Controls.Add(this.workerbeeJob);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bee Hive Management System";
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerbeeJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button assignJobButton;
        private System.Windows.Forms.Button nextShiftButton;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

