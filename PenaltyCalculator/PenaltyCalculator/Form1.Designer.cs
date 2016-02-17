namespace PenaltyCalculator
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
			this.contractSumText = new System.Windows.Forms.TextBox();
			this.penaltySumText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.currentDate = new System.Windows.Forms.DateTimePicker();
			this.contractEndDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.saveReportButtton = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// contractSumText
			// 
			this.contractSumText.Location = new System.Drawing.Point(181, 34);
			this.contractSumText.Name = "contractSumText";
			this.contractSumText.Size = new System.Drawing.Size(140, 20);
			this.contractSumText.TabIndex = 0;
			// 
			// penaltySumText
			// 
			this.penaltySumText.Location = new System.Drawing.Point(327, 33);
			this.penaltySumText.Name = "penaltySumText";
			this.penaltySumText.Size = new System.Drawing.Size(54, 20);
			this.penaltySumText.TabIndex = 1;
			this.penaltySumText.TextChanged += new System.EventHandler(this.penaltySumText_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Сумма по договору, руб";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(324, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Пеня, %";
			// 
			// currentDate
			// 
			this.currentDate.Location = new System.Drawing.Point(181, 112);
			this.currentDate.Name = "currentDate";
			this.currentDate.Size = new System.Drawing.Size(200, 20);
			this.currentDate.TabIndex = 5;
			// 
			// contractEndDate
			// 
			this.contractEndDate.Location = new System.Drawing.Point(181, 86);
			this.contractEndDate.Name = "contractEndDate";
			this.contractEndDate.Size = new System.Drawing.Size(200, 20);
			this.contractEndDate.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Дата окончания договора";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 118);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Дата на момент расчета пени";
			// 
			// saveReportButtton
			// 
			this.saveReportButtton.Location = new System.Drawing.Point(15, 156);
			this.saveReportButtton.Name = "saveReportButtton";
			this.saveReportButtton.Size = new System.Drawing.Size(366, 44);
			this.saveReportButtton.TabIndex = 10;
			this.saveReportButtton.Text = "Сохранить отчет";
			this.saveReportButtton.UseVisualStyleBackColor = true;
			this.saveReportButtton.Click += new System.EventHandler(this.saveReportButtton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 212);
			this.Controls.Add(this.saveReportButtton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.contractEndDate);
			this.Controls.Add(this.currentDate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.penaltySumText);
			this.Controls.Add(this.contractSumText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Penalty Calculator v1.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox contractSumText;
		private System.Windows.Forms.TextBox penaltySumText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker currentDate;
		private System.Windows.Forms.DateTimePicker contractEndDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button saveReportButtton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}

