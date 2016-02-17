using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettersGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            listBox.Items.Add((Keys)random.Next(65, 90));
            if (listBox.Items.Count > 7)
            {
                listBox.Items.Clear();
                listBox.Items.Add("Game Over!");
                timer.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox.Items.Contains(e.KeyCode))
            {
                listBox.Items.Remove(e.KeyCode);
                listBox.Refresh();
                if (timer.Interval > 400)
                {
                    timer.Interval -= 10;
                }
                if (timer.Interval > 250)
                {
                    timer.Interval -= 7;
                }
                if (timer.Interval > 100)
                {
                    timer.Interval -= 2;
                }
                difficultyProgressBar.Value = 800 - timer.Interval;
                stats.UpdateStats(true);
            }
            else
            {
                stats.UpdateStats(false);
            }
            correctLabel.Text = "Correct" + stats._correct;
            missedLabel.Text = "Missed" + stats._missed;
            totalLabel.Text = "Total" + stats._total;
            accuracyLabel.Text = "Accuracy" + stats._accuracy + "%";
        }
    }
}
