using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveApp
{
    public partial class Form1 : Form
    {
        private Queen queen;
        NectarStinger fred = new NectarStinger(new string[] { "Nectar collector", "Sting patrol" }, 200);

        public Form1()
        {
            InitializeComponent();
            workerbeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufactoring" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufactoring", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
            queen = new Queen(workers, 275);
            IStingPatrol george = fred;
        }

        private void assignJobButton_Click(object sender, EventArgs e)
        {
            if (queen.AssignToWork(workerbeeJob.Text, (int)shifts.Value) == false)
            {
                MessageBox.Show("There are no workers for this job '" + workerbeeJob.Text + "' Queen says");
            }
            else
            {
                MessageBox.Show("Job '" + workerbeeJob.Text + "' will be finished in " + shifts.Value + " shifts", "Queen says");
            }
        }

        private void nextShiftButton_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
