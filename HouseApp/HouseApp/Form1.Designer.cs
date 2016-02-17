namespace HouseApp
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
			this.goHereButton = new System.Windows.Forms.Button();
			this.goThroughTheDoorButton = new System.Windows.Forms.Button();
			this.exitsComboBox = new System.Windows.Forms.ComboBox();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.checkButton = new System.Windows.Forms.Button();
			this.hideButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// goHereButton
			// 
			this.goHereButton.Location = new System.Drawing.Point(12, 266);
			this.goHereButton.Name = "goHereButton";
			this.goHereButton.Size = new System.Drawing.Size(75, 23);
			this.goHereButton.TabIndex = 0;
			this.goHereButton.Text = "Go here:";
			this.goHereButton.UseVisualStyleBackColor = true;
			this.goHereButton.Click += new System.EventHandler(this.goHereButton_Click);
			// 
			// goThroughTheDoorButton
			// 
			this.goThroughTheDoorButton.Location = new System.Drawing.Point(12, 295);
			this.goThroughTheDoorButton.Name = "goThroughTheDoorButton";
			this.goThroughTheDoorButton.Size = new System.Drawing.Size(298, 23);
			this.goThroughTheDoorButton.TabIndex = 1;
			this.goThroughTheDoorButton.Text = "Go through the door";
			this.goThroughTheDoorButton.UseVisualStyleBackColor = true;
			this.goThroughTheDoorButton.Click += new System.EventHandler(this.goThroughTheDoorButton_Click);
			// 
			// exitsComboBox
			// 
			this.exitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.exitsComboBox.FormattingEnabled = true;
			this.exitsComboBox.Location = new System.Drawing.Point(93, 268);
			this.exitsComboBox.Name = "exitsComboBox";
			this.exitsComboBox.Size = new System.Drawing.Size(217, 21);
			this.exitsComboBox.TabIndex = 2;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(12, 12);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(298, 238);
			this.descriptionTextBox.TabIndex = 3;
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(12, 324);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(298, 23);
			this.checkButton.TabIndex = 4;
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Visible = false;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// hideButton
			// 
			this.hideButton.Location = new System.Drawing.Point(12, 353);
			this.hideButton.Name = "hideButton";
			this.hideButton.Size = new System.Drawing.Size(298, 23);
			this.hideButton.TabIndex = 5;
			this.hideButton.Text = "Hide!";
			this.hideButton.UseVisualStyleBackColor = true;
			this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 383);
			this.Controls.Add(this.hideButton);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.exitsComboBox);
			this.Controls.Add(this.goThroughTheDoorButton);
			this.Controls.Add(this.goHereButton);
			this.Name = "Form1";
			this.Text = "Explore th House";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button goHereButton;
		private System.Windows.Forms.Button goThroughTheDoorButton;
		private System.Windows.Forms.ComboBox exitsComboBox;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.Button hideButton;
	}
}

