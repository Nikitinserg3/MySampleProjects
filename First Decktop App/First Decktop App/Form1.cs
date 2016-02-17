using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Decktop_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeText_Click(object sender, EventArgs e)
        {
            if (enableCheckBox.Checked == true)
            {
                if (labelText.Text == "Right")
                {
                    labelText.Text = "Left";
                    labelText.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    labelText.Text = "Right";
                    labelText.TextAlign = ContentAlignment.MiddleRight;
                }
                
            }
            else
            {
                labelText.Text = "No way!";
                labelText.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
