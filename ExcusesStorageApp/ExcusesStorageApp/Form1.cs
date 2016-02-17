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

namespace ExcusesStorageApp
{
	public partial class Form1 : Form
	{
		private Excuse currentExcuse = new Excuse();
		private string selectedFolder = "";
		private bool formChanged = false;
		Random random = new Random();
	

		

		public Form1()
		{
			InitializeComponent();
			currentExcuse.LastUsed = lastUsed.Value;
		}

		private void folderButton_Click(object sender, EventArgs e)
		{
			folderBrowserDialog.SelectedPath = selectedFolder;
			DialogResult result = folderBrowserDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				selectedFolder = folderBrowserDialog.SelectedPath;
				saveButton.Enabled = true;
				openButton.Enabled = true;
				randomButton.Enabled = true;
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(description.Text)|| String.IsNullOrEmpty(results.Text))
			{
				MessageBox.Show("Please, specify an excuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			saveFileDialog.InitialDirectory = selectedFolder;
			saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog.FileName = description.Text + ".txt";
			DialogResult result = saveFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				currentExcuse.Save(saveFileDialog.FileName);
				UpdateForm(false);
				MessageBox.Show("Excuse written");
			}
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			if (CheckChanged())
			{
				openFileDialog.InitialDirectory = selectedFolder;
				openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FileName = description.Text + ".txt";
				DialogResult result = openFileDialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					currentExcuse = new Excuse(openFileDialog.FileName);
					UpdateForm(false);
				}
            }
		}

		private void randomButton_Click(object sender, EventArgs e)
		{
			if (CheckChanged())
			{
				currentExcuse = new Excuse(random, selectedFolder);
				UpdateForm(false);
			}
		}

		private bool CheckChanged()
		{
			if (formChanged)
			{
				DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.No)
				{
					return false;
				}
			}
			return true;
		}

		private void description_TextChanged(object sender, EventArgs e)
		{
			currentExcuse.Description = description.Text;
			UpdateForm(true);
		}

		private void results_TextChanged(object sender, EventArgs e)
		{
			currentExcuse.Results = results.Text;
			UpdateForm(true);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			currentExcuse.LastUsed = lastUsed.Value;
			UpdateForm(true);
		}

		public void UpdateForm(bool changed)
		{
			if (!changed)
			{
				description.Text = currentExcuse.Description;
				results.Text = currentExcuse.Results;
				lastUsed.Value = currentExcuse.LastUsed;
				if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
				{
					fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
					Text = "Excuse Manager";
				}
				else
				{
					Text = "Excuse Manager*";
				}
			}
			formChanged = changed;
		}
	}
}
