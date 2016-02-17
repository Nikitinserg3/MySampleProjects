namespace FeedLumberJackApp
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
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.addLumberjackButton = new System.Windows.Forms.Button();
			this.lineListBox = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.nextInLine = new System.Windows.Forms.TextBox();
			this.addFlapjackButton = new System.Windows.Forms.Button();
			this.nextLumberjackButton = new System.Windows.Forms.Button();
			this.bananaButton = new System.Windows.Forms.RadioButton();
			this.brownedButton = new System.Windows.Forms.RadioButton();
			this.soggyButton = new System.Windows.Forms.RadioButton();
			this.crispyButton = new System.Windows.Forms.RadioButton();
			this.howManyNumeric = new System.Windows.Forms.NumericUpDown();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.howManyNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(109, 6);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(226, 20);
			this.nameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lumberjack name";
			// 
			// addLumberjackButton
			// 
			this.addLumberjackButton.Location = new System.Drawing.Point(15, 41);
			this.addLumberjackButton.Name = "addLumberjackButton";
			this.addLumberjackButton.Size = new System.Drawing.Size(320, 27);
			this.addLumberjackButton.TabIndex = 2;
			this.addLumberjackButton.Text = "Add lumberjack";
			this.addLumberjackButton.UseVisualStyleBackColor = true;
			this.addLumberjackButton.Click += new System.EventHandler(this.addLumberjackButton_Click);
			// 
			// lineListBox
			// 
			this.lineListBox.FormattingEnabled = true;
			this.lineListBox.Location = new System.Drawing.Point(12, 107);
			this.lineListBox.Name = "lineListBox";
			this.lineListBox.Size = new System.Drawing.Size(120, 264);
			this.lineListBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Breakfast line";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nextInLine);
			this.groupBox1.Controls.Add(this.addFlapjackButton);
			this.groupBox1.Controls.Add(this.nextLumberjackButton);
			this.groupBox1.Controls.Add(this.bananaButton);
			this.groupBox1.Controls.Add(this.brownedButton);
			this.groupBox1.Controls.Add(this.soggyButton);
			this.groupBox1.Controls.Add(this.crispyButton);
			this.groupBox1.Controls.Add(this.howManyNumeric);
			this.groupBox1.Location = new System.Drawing.Point(141, 91);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 280);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Feed a Lumberjack";
			// 
			// nextInLine
			// 
			this.nextInLine.Location = new System.Drawing.Point(6, 166);
			this.nextInLine.Multiline = true;
			this.nextInLine.Name = "nextInLine";
			this.nextInLine.ReadOnly = true;
			this.nextInLine.Size = new System.Drawing.Size(188, 79);
			this.nextInLine.TabIndex = 7;
			// 
			// addFlapjackButton
			// 
			this.addFlapjackButton.Location = new System.Drawing.Point(6, 137);
			this.addFlapjackButton.Name = "addFlapjackButton";
			this.addFlapjackButton.Size = new System.Drawing.Size(188, 23);
			this.addFlapjackButton.TabIndex = 6;
			this.addFlapjackButton.Text = "Add flapjack";
			this.addFlapjackButton.UseVisualStyleBackColor = true;
			this.addFlapjackButton.Click += new System.EventHandler(this.addFlapjackButton_Click);
			// 
			// nextLumberjackButton
			// 
			this.nextLumberjackButton.Location = new System.Drawing.Point(6, 251);
			this.nextLumberjackButton.Name = "nextLumberjackButton";
			this.nextLumberjackButton.Size = new System.Drawing.Size(188, 23);
			this.nextLumberjackButton.TabIndex = 5;
			this.nextLumberjackButton.Text = "Next lumberjack";
			this.nextLumberjackButton.UseVisualStyleBackColor = true;
			this.nextLumberjackButton.Click += new System.EventHandler(this.nextLumberjackButton_Click);
			// 
			// bananaButton
			// 
			this.bananaButton.AutoSize = true;
			this.bananaButton.Location = new System.Drawing.Point(6, 114);
			this.bananaButton.Name = "bananaButton";
			this.bananaButton.Size = new System.Drawing.Size(62, 17);
			this.bananaButton.TabIndex = 4;
			this.bananaButton.TabStop = true;
			this.bananaButton.Text = "Banana";
			this.bananaButton.UseVisualStyleBackColor = true;
			// 
			// brownedButton
			// 
			this.brownedButton.AutoSize = true;
			this.brownedButton.Location = new System.Drawing.Point(6, 91);
			this.brownedButton.Name = "brownedButton";
			this.brownedButton.Size = new System.Drawing.Size(67, 17);
			this.brownedButton.TabIndex = 3;
			this.brownedButton.TabStop = true;
			this.brownedButton.Text = "Browned";
			this.brownedButton.UseVisualStyleBackColor = true;
			// 
			// soggyButton
			// 
			this.soggyButton.AutoSize = true;
			this.soggyButton.Location = new System.Drawing.Point(6, 68);
			this.soggyButton.Name = "soggyButton";
			this.soggyButton.Size = new System.Drawing.Size(55, 17);
			this.soggyButton.TabIndex = 2;
			this.soggyButton.TabStop = true;
			this.soggyButton.Text = "Soggy";
			this.soggyButton.UseVisualStyleBackColor = true;
			// 
			// crispyButton
			// 
			this.crispyButton.AutoSize = true;
			this.crispyButton.Location = new System.Drawing.Point(6, 45);
			this.crispyButton.Name = "crispyButton";
			this.crispyButton.Size = new System.Drawing.Size(53, 17);
			this.crispyButton.TabIndex = 1;
			this.crispyButton.TabStop = true;
			this.crispyButton.Text = "Crispy";
			this.crispyButton.UseVisualStyleBackColor = true;
			// 
			// howManyNumeric
			// 
			this.howManyNumeric.Location = new System.Drawing.Point(6, 19);
			this.howManyNumeric.Name = "howManyNumeric";
			this.howManyNumeric.Size = new System.Drawing.Size(188, 20);
			this.howManyNumeric.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 378);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lineListBox);
			this.Controls.Add(this.addLumberjackButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameTextBox);
			this.Name = "Form1";
			this.Text = "Breakfast For Lumberjacks";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.howManyNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addLumberjackButton;
		private System.Windows.Forms.ListBox lineListBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button nextLumberjackButton;
		private System.Windows.Forms.RadioButton bananaButton;
		private System.Windows.Forms.RadioButton brownedButton;
		private System.Windows.Forms.RadioButton soggyButton;
		private System.Windows.Forms.RadioButton crispyButton;
		private System.Windows.Forms.NumericUpDown howManyNumeric;
		private System.Windows.Forms.Button addFlapjackButton;
		private System.Windows.Forms.TextBox nextInLine;
	}
}

