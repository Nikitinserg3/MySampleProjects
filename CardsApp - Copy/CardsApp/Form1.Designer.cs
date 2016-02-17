namespace CardsApp
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
			this.cardSelecterButton = new System.Windows.Forms.Button();
			this.textBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cardSelecterButton
			// 
			this.cardSelecterButton.Location = new System.Drawing.Point(145, 287);
			this.cardSelecterButton.Name = "cardSelecterButton";
			this.cardSelecterButton.Size = new System.Drawing.Size(144, 94);
			this.cardSelecterButton.TabIndex = 0;
			this.cardSelecterButton.Text = "PRESS ME";
			this.cardSelecterButton.UseVisualStyleBackColor = true;
			this.cardSelecterButton.Click += new System.EventHandler(this.cardSelecterButton_Click);
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(12, 12);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(427, 269);
			this.textBox.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 393);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.cardSelecterButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cardSelecterButton;
		private System.Windows.Forms.TextBox textBox;
	}
}

