namespace ExcusesStorageApp
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
			this.folderButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.openButton = new System.Windows.Forms.Button();
			this.randomButton = new System.Windows.Forms.Button();
			this.results = new System.Windows.Forms.TextBox();
			this.description = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lastUsed = new System.Windows.Forms.DateTimePicker();
			this.fileDate = new System.Windows.Forms.Label();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// folderButton
			// 
			this.folderButton.Location = new System.Drawing.Point(12, 154);
			this.folderButton.Name = "folderButton";
			this.folderButton.Size = new System.Drawing.Size(139, 23);
			this.folderButton.TabIndex = 0;
			this.folderButton.Text = "Folder";
			this.folderButton.UseVisualStyleBackColor = true;
			this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(157, 154);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(139, 23);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(302, 154);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(137, 23);
			this.openButton.TabIndex = 2;
			this.openButton.Text = "Open";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// randomButton
			// 
			this.randomButton.Location = new System.Drawing.Point(445, 154);
			this.randomButton.Name = "randomButton";
			this.randomButton.Size = new System.Drawing.Size(132, 23);
			this.randomButton.TabIndex = 3;
			this.randomButton.Text = "Random";
			this.randomButton.UseVisualStyleBackColor = true;
			this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
			// 
			// results
			// 
			this.results.Location = new System.Drawing.Point(113, 38);
			this.results.Name = "results";
			this.results.Size = new System.Drawing.Size(464, 20);
			this.results.TabIndex = 4;
			this.results.TextChanged += new System.EventHandler(this.results_TextChanged);
			// 
			// description
			// 
			this.description.Location = new System.Drawing.Point(113, 12);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(464, 20);
			this.description.TabIndex = 5;
			this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Excuse";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Results";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Last Used";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "File Date";
			// 
			// lastUsed
			// 
			this.lastUsed.Location = new System.Drawing.Point(113, 64);
			this.lastUsed.Name = "lastUsed";
			this.lastUsed.Size = new System.Drawing.Size(206, 20);
			this.lastUsed.TabIndex = 10;
			this.lastUsed.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// fileDate
			// 
			this.fileDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.fileDate.Location = new System.Drawing.Point(110, 97);
			this.fileDate.Name = "fileDate";
			this.fileDate.Size = new System.Drawing.Size(209, 23);
			this.fileDate.TabIndex = 11;
			// 
			// folderBrowserDialog
			// 
			this.folderBrowserDialog.SelectedPath = "D:\\My stuff\\DEV\\Excuses";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 189);
			this.Controls.Add(this.fileDate);
			this.Controls.Add(this.lastUsed);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.description);
			this.Controls.Add(this.results);
			this.Controls.Add(this.randomButton);
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.folderButton);
			this.Name = "Form1";
			this.Text = "Excuse Manager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button folderButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.Button randomButton;
		private System.Windows.Forms.TextBox results;
		private System.Windows.Forms.TextBox description;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker lastUsed;
		private System.Windows.Forms.Label fileDate;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

