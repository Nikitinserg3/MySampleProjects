namespace Guyz
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
			this.JoeCashLabel = new System.Windows.Forms.Label();
			this.bobCashLabel = new System.Windows.Forms.Label();
			this.bankCashLabel = new System.Windows.Forms.Label();
			this.joeReceivesCashButton = new System.Windows.Forms.Button();
			this.bobGivesCashButton = new System.Windows.Forms.Button();
			this.joeGivesCashToBobButton = new System.Windows.Forms.Button();
			this.bobGivesCashToJoe = new System.Windows.Forms.Button();
			this.saveJoeButton = new System.Windows.Forms.Button();
			this.loadJoeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// JoeCashLabel
			// 
			this.JoeCashLabel.AutoSize = true;
			this.JoeCashLabel.Location = new System.Drawing.Point(37, 21);
			this.JoeCashLabel.Name = "JoeCashLabel";
			this.JoeCashLabel.Size = new System.Drawing.Size(35, 13);
			this.JoeCashLabel.TabIndex = 0;
			this.JoeCashLabel.Text = "label1";
			// 
			// bobCashLabel
			// 
			this.bobCashLabel.AutoSize = true;
			this.bobCashLabel.Location = new System.Drawing.Point(37, 54);
			this.bobCashLabel.Name = "bobCashLabel";
			this.bobCashLabel.Size = new System.Drawing.Size(35, 13);
			this.bobCashLabel.TabIndex = 1;
			this.bobCashLabel.Text = "label2";
			// 
			// bankCashLabel
			// 
			this.bankCashLabel.AutoSize = true;
			this.bankCashLabel.Location = new System.Drawing.Point(37, 91);
			this.bankCashLabel.Name = "bankCashLabel";
			this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
			this.bankCashLabel.TabIndex = 2;
			this.bankCashLabel.Text = "label3";
			// 
			// joeReceivesCashButton
			// 
			this.joeReceivesCashButton.Location = new System.Drawing.Point(12, 138);
			this.joeReceivesCashButton.Name = "joeReceivesCashButton";
			this.joeReceivesCashButton.Size = new System.Drawing.Size(116, 60);
			this.joeReceivesCashButton.TabIndex = 3;
			this.joeReceivesCashButton.Text = "Give 10$ to Joe from Bank";
			this.joeReceivesCashButton.UseVisualStyleBackColor = true;
			this.joeReceivesCashButton.Click += new System.EventHandler(this.joeReceivesCashButton_Click);
			// 
			// bobGivesCashButton
			// 
			this.bobGivesCashButton.Location = new System.Drawing.Point(156, 138);
			this.bobGivesCashButton.Name = "bobGivesCashButton";
			this.bobGivesCashButton.Size = new System.Drawing.Size(116, 60);
			this.bobGivesCashButton.TabIndex = 4;
			this.bobGivesCashButton.Text = "Bank Receives 5$ from Bob";
			this.bobGivesCashButton.UseVisualStyleBackColor = true;
			this.bobGivesCashButton.Click += new System.EventHandler(this.bobGivesCashButton_Click);
			// 
			// joeGivesCashToBobButton
			// 
			this.joeGivesCashToBobButton.Location = new System.Drawing.Point(12, 224);
			this.joeGivesCashToBobButton.Name = "joeGivesCashToBobButton";
			this.joeGivesCashToBobButton.Size = new System.Drawing.Size(116, 62);
			this.joeGivesCashToBobButton.TabIndex = 5;
			this.joeGivesCashToBobButton.Text = "Joe gives 10$ to Bob";
			this.joeGivesCashToBobButton.UseVisualStyleBackColor = true;
			this.joeGivesCashToBobButton.Click += new System.EventHandler(this.joeGivesCashToBobButton_Click);
			// 
			// bobGivesCashToJoe
			// 
			this.bobGivesCashToJoe.Location = new System.Drawing.Point(156, 224);
			this.bobGivesCashToJoe.Name = "bobGivesCashToJoe";
			this.bobGivesCashToJoe.Size = new System.Drawing.Size(116, 62);
			this.bobGivesCashToJoe.TabIndex = 6;
			this.bobGivesCashToJoe.Text = "Bob gives 5$ to Joe";
			this.bobGivesCashToJoe.UseVisualStyleBackColor = true;
			this.bobGivesCashToJoe.Click += new System.EventHandler(this.bobGivesCashToJoe_Click);
			// 
			// saveJoeButton
			// 
			this.saveJoeButton.Location = new System.Drawing.Point(12, 325);
			this.saveJoeButton.Name = "saveJoeButton";
			this.saveJoeButton.Size = new System.Drawing.Size(116, 23);
			this.saveJoeButton.TabIndex = 7;
			this.saveJoeButton.Text = "Save Joe";
			this.saveJoeButton.UseVisualStyleBackColor = true;
			this.saveJoeButton.Click += new System.EventHandler(this.saveJoeButton_Click);
			// 
			// loadJoeButton
			// 
			this.loadJoeButton.Location = new System.Drawing.Point(156, 325);
			this.loadJoeButton.Name = "loadJoeButton";
			this.loadJoeButton.Size = new System.Drawing.Size(116, 23);
			this.loadJoeButton.TabIndex = 8;
			this.loadJoeButton.Text = "Load Joe";
			this.loadJoeButton.UseVisualStyleBackColor = true;
			this.loadJoeButton.Click += new System.EventHandler(this.loadJoeButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 360);
			this.Controls.Add(this.loadJoeButton);
			this.Controls.Add(this.saveJoeButton);
			this.Controls.Add(this.bobGivesCashToJoe);
			this.Controls.Add(this.joeGivesCashToBobButton);
			this.Controls.Add(this.bobGivesCashButton);
			this.Controls.Add(this.joeReceivesCashButton);
			this.Controls.Add(this.bankCashLabel);
			this.Controls.Add(this.bobCashLabel);
			this.Controls.Add(this.JoeCashLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoeCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button joeReceivesCashButton;
        private System.Windows.Forms.Button bobGivesCashButton;
        private System.Windows.Forms.Button joeGivesCashToBobButton;
        private System.Windows.Forms.Button bobGivesCashToJoe;
		private System.Windows.Forms.Button saveJoeButton;
		private System.Windows.Forms.Button loadJoeButton;
	}
}

