namespace DinnerParty
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
            this.numberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.fancyDecorationCheck = new System.Windows.Forms.CheckBox();
            this.healthyOptionCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfGuests
            // 
            this.numberOfGuests.Location = new System.Drawing.Point(48, 56);
            this.numberOfGuests.Name = "numberOfGuests";
            this.numberOfGuests.Size = new System.Drawing.Size(120, 20);
            this.numberOfGuests.TabIndex = 0;
            this.numberOfGuests.ValueChanged += new System.EventHandler(this.numberOfGuests_ValueChanged);
            // 
            // fancyDecorationCheck
            // 
            this.fancyDecorationCheck.AutoSize = true;
            this.fancyDecorationCheck.Location = new System.Drawing.Point(48, 92);
            this.fancyDecorationCheck.Name = "fancyDecorationCheck";
            this.fancyDecorationCheck.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorationCheck.TabIndex = 1;
            this.fancyDecorationCheck.Text = "Fancy Decorations";
            this.fancyDecorationCheck.UseVisualStyleBackColor = true;
            this.fancyDecorationCheck.CheckedChanged += new System.EventHandler(this.fancyDecorationCheck_CheckedChanged);
            // 
            // healthyOptionCheck
            // 
            this.healthyOptionCheck.AutoSize = true;
            this.healthyOptionCheck.Location = new System.Drawing.Point(48, 115);
            this.healthyOptionCheck.Name = "healthyOptionCheck";
            this.healthyOptionCheck.Size = new System.Drawing.Size(96, 17);
            this.healthyOptionCheck.TabIndex = 2;
            this.healthyOptionCheck.Text = "Healthy Option";
            this.healthyOptionCheck.UseVisualStyleBackColor = true;
            this.healthyOptionCheck.CheckedChanged += new System.EventHandler(this.healthyOptionCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of Guests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost = ";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(58, 152);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(55, 13);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "Total Cost";
            this.totalCostLabel.Click += new System.EventHandler(this.totalCostLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 195);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthyOptionCheck);
            this.Controls.Add(this.fancyDecorationCheck);
            this.Controls.Add(this.numberOfGuests);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberOfGuests;
        private System.Windows.Forms.CheckBox fancyDecorationCheck;
        private System.Windows.Forms.CheckBox healthyOptionCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalCostLabel;
    }
}

