namespace MovingCardsApp
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
			this.deck1ListBox = new System.Windows.Forms.ListBox();
			this.deck2ListBox = new System.Windows.Forms.ListBox();
			this.moveToDeck2Button = new System.Windows.Forms.Button();
			this.moveToDeck1Button = new System.Windows.Forms.Button();
			this.shuffleDeck2Button = new System.Windows.Forms.Button();
			this.resetDeck2Button = new System.Windows.Forms.Button();
			this.shuffleDeck1Button = new System.Windows.Forms.Button();
			this.resetDeck1Button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// deck1ListBox
			// 
			this.deck1ListBox.FormattingEnabled = true;
			this.deck1ListBox.Location = new System.Drawing.Point(12, 38);
			this.deck1ListBox.Name = "deck1ListBox";
			this.deck1ListBox.Size = new System.Drawing.Size(188, 316);
			this.deck1ListBox.TabIndex = 0;
			this.deck1ListBox.Tag = "";
			// 
			// deck2ListBox
			// 
			this.deck2ListBox.FormattingEnabled = true;
			this.deck2ListBox.Location = new System.Drawing.Point(287, 38);
			this.deck2ListBox.Name = "deck2ListBox";
			this.deck2ListBox.Size = new System.Drawing.Size(186, 316);
			this.deck2ListBox.TabIndex = 1;
			// 
			// moveToDeck2Button
			// 
			this.moveToDeck2Button.Location = new System.Drawing.Point(206, 166);
			this.moveToDeck2Button.Name = "moveToDeck2Button";
			this.moveToDeck2Button.Size = new System.Drawing.Size(75, 23);
			this.moveToDeck2Button.TabIndex = 2;
			this.moveToDeck2Button.Text = ">>";
			this.moveToDeck2Button.UseVisualStyleBackColor = true;
			this.moveToDeck2Button.Click += new System.EventHandler(this.moveToDeck2Button_Click);
			// 
			// moveToDeck1Button
			// 
			this.moveToDeck1Button.Location = new System.Drawing.Point(206, 195);
			this.moveToDeck1Button.Name = "moveToDeck1Button";
			this.moveToDeck1Button.Size = new System.Drawing.Size(75, 23);
			this.moveToDeck1Button.TabIndex = 3;
			this.moveToDeck1Button.Text = "<<";
			this.moveToDeck1Button.UseVisualStyleBackColor = true;
			this.moveToDeck1Button.Click += new System.EventHandler(this.moveToDeck1Button_Click);
			// 
			// shuffleDeck2Button
			// 
			this.shuffleDeck2Button.Location = new System.Drawing.Point(287, 413);
			this.shuffleDeck2Button.Name = "shuffleDeck2Button";
			this.shuffleDeck2Button.Size = new System.Drawing.Size(186, 50);
			this.shuffleDeck2Button.TabIndex = 4;
			this.shuffleDeck2Button.Text = "Shuffle deck #2";
			this.shuffleDeck2Button.UseVisualStyleBackColor = true;
			this.shuffleDeck2Button.Click += new System.EventHandler(this.shuffleDeck2Button_Click);
			// 
			// resetDeck2Button
			// 
			this.resetDeck2Button.Location = new System.Drawing.Point(287, 360);
			this.resetDeck2Button.Name = "resetDeck2Button";
			this.resetDeck2Button.Size = new System.Drawing.Size(186, 47);
			this.resetDeck2Button.TabIndex = 5;
			this.resetDeck2Button.Text = "Reset deck #2";
			this.resetDeck2Button.UseVisualStyleBackColor = true;
			this.resetDeck2Button.Click += new System.EventHandler(this.resetDeck2Button_Click);
			// 
			// shuffleDeck1Button
			// 
			this.shuffleDeck1Button.Location = new System.Drawing.Point(12, 413);
			this.shuffleDeck1Button.Name = "shuffleDeck1Button";
			this.shuffleDeck1Button.Size = new System.Drawing.Size(188, 50);
			this.shuffleDeck1Button.TabIndex = 6;
			this.shuffleDeck1Button.Text = "Shuffle deck #1";
			this.shuffleDeck1Button.UseVisualStyleBackColor = true;
			this.shuffleDeck1Button.Click += new System.EventHandler(this.shuffleDeck1Button_Click);
			// 
			// resetDeck1Button
			// 
			this.resetDeck1Button.Location = new System.Drawing.Point(12, 360);
			this.resetDeck1Button.Name = "resetDeck1Button";
			this.resetDeck1Button.Size = new System.Drawing.Size(188, 47);
			this.resetDeck1Button.TabIndex = 7;
			this.resetDeck1Button.Text = "Reset deck #1";
			this.resetDeck1Button.UseVisualStyleBackColor = true;
			this.resetDeck1Button.Click += new System.EventHandler(this.resetDeck1Button_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Deck #1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(284, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Deck #2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 474);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resetDeck1Button);
			this.Controls.Add(this.shuffleDeck1Button);
			this.Controls.Add(this.resetDeck2Button);
			this.Controls.Add(this.shuffleDeck2Button);
			this.Controls.Add(this.moveToDeck1Button);
			this.Controls.Add(this.moveToDeck2Button);
			this.Controls.Add(this.deck2ListBox);
			this.Controls.Add(this.deck1ListBox);
			this.Name = "Form1";
			this.Text = "Two Decks";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox deck1ListBox;
		private System.Windows.Forms.ListBox deck2ListBox;
		private System.Windows.Forms.Button moveToDeck2Button;
		private System.Windows.Forms.Button moveToDeck1Button;
		private System.Windows.Forms.Button shuffleDeck2Button;
		private System.Windows.Forms.Button resetDeck2Button;
		private System.Windows.Forms.Button shuffleDeck1Button;
		private System.Windows.Forms.Button resetDeck1Button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

