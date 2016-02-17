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
using System.Runtime.Serialization.Formatters.Binary;

namespace Guyz
{
    public partial class Form1 : Form
    {
        private Guy _joe;
        private Guy _bob;
        private int _bank = 100;

        public Form1()
        {
            InitializeComponent();
            _joe = new Guy();
            _bob = new Guy();
            _joe.Name = "Joe";
            _bob.Name = "Bob";
            _joe.Cash = 50;
            _bob.Cash = 100;
            _bank = 100;
            UpdateForm();

        }

        public void UpdateForm()
        {
            JoeCashLabel.Text = _joe.Name + " имеет $ " + _joe.Cash;
            bobCashLabel.Text = _bob.Name + " имеет $ " + _bob.Cash;
            bankCashLabel.Text = "В банке сейчас $ " + _bank;
        }

        private void joeReceivesCashButton_Click(object sender, EventArgs e)
        {
            if (_bank >= 10)
            {
                _bank -= _joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("В банке недостаточно денег");
            }
        }

        private void bobGivesCashButton_Click(object sender, EventArgs e)
        {
            _bank += _bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesCashToBobButton_Click(object sender, EventArgs e)
        {
            if (_joe.Cash >= 10)
            {
                _joe.Cash -= _joe.GiveCash(10);
                _bob.Cash += _bob.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("У Джо не хватает бабок.");
            }
        }

        private void bobGivesCashToJoe_Click(object sender, EventArgs e)
        {
            if (_bob.Cash >= 5)
            {
                _bob.Cash -= _bob.GiveCash(5);
                _joe.Cash += _joe.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("У Боба не хватает бабок.");
            }
        }

		private void saveJoeButton_Click(object sender, EventArgs e)
		{
			using (Stream output = File.Create("Guy_file.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(output,_joe);
			}
		}

		private void loadJoeButton_Click(object sender, EventArgs e)
		{
			using (Stream input = File.OpenRead("Guy_file.dat"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				_joe = (Guy)formatter.Deserialize(input);
			}
			UpdateForm();
		}
	}
}
