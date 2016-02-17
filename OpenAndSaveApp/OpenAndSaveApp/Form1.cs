using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OpenAndSaveApp
{
	public partial class Form1 : Form
	{
		private string _name;

		public Form1()
		{
			InitializeComponent();
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				_name = openFileDialog.FileName;
				textBox.Clear();
				textBox.Text = File.ReadAllText(_name);
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				_name = saveFileDialog.FileName;
				File.WriteAllText(_name, textBox.Text);
			}
		}
	}
}
