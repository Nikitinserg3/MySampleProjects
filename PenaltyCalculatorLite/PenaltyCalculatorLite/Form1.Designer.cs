namespace PenaltyCalculatorLite
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.daysTextBox = new System.Windows.Forms.TextBox();
			this.penaltyTextBox = new System.Windows.Forms.TextBox();
			this.sumTextBox = new System.Windows.Forms.TextBox();
			this.saveReportButton = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Сумма";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пеня, %";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Количество просроченных дней";
			// 
			// daysTextBox
			// 
			this.daysTextBox.Location = new System.Drawing.Point(202, 61);
			this.daysTextBox.Name = "daysTextBox";
			this.daysTextBox.Size = new System.Drawing.Size(100, 20);
			this.daysTextBox.TabIndex = 3;
			// 
			// penaltyTextBox
			// 
			this.penaltyTextBox.Location = new System.Drawing.Point(202, 35);
			this.penaltyTextBox.Name = "penaltyTextBox";
			this.penaltyTextBox.Size = new System.Drawing.Size(100, 20);
			this.penaltyTextBox.TabIndex = 4;
			// 
			// sumTextBox
			// 
			this.sumTextBox.Location = new System.Drawing.Point(202, 9);
			this.sumTextBox.Name = "sumTextBox";
			this.sumTextBox.Size = new System.Drawing.Size(100, 20);
			this.sumTextBox.TabIndex = 5;
			// 
			// saveReportButton
			// 
			this.saveReportButton.Location = new System.Drawing.Point(12, 113);
			this.saveReportButton.Name = "saveReportButton";
			this.saveReportButton.Size = new System.Drawing.Size(290, 49);
			this.saveReportButton.TabIndex = 6;
			this.saveReportButton.Text = "Расчитать и сохранить";
			this.saveReportButton.UseVisualStyleBackColor = true;
			this.saveReportButton.Click += new System.EventHandler(this.saveReportButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 174);
			this.Controls.Add(this.saveReportButton);
			this.Controls.Add(this.sumTextBox);
			this.Controls.Add(this.penaltyTextBox);
			this.Controls.Add(this.daysTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Расчет пени";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox daysTextBox;
		private System.Windows.Forms.TextBox penaltyTextBox;
		private System.Windows.Forms.TextBox sumTextBox;
		private System.Windows.Forms.Button saveReportButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

