namespace CardApp_vol._2
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
			this.checkButton = new System.Windows.Forms.Button();
			this.textBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(11, 199);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(260, 50);
			this.checkButton.TabIndex = 0;
			this.checkButton.Text = "button1";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(11, 12);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(260, 181);
			this.textBox.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 261);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.checkButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.TextBox textBox;
	}
}

