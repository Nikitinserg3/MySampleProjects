using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballPlayersApp
{
	public partial class Form1 : Form
	{
		Dictionary<int, PlayerInfo> dataBase = new Dictionary<int, PlayerInfo>()
		
		public Form1()
		{
			InitializeComponent();
			dataBase.Add(1, new PlayerInfo("Johny","Montana",1987));
			dataBase.Add(2, new PlayerInfo("Max", "Mad", 1907));
			dataBase.Add(3, new PlayerInfo("Bobby", "Dilan", 1999));
			dataBase.Add(4, new PlayerInfo("Leonardo", "Di Caprio", 1965));
			dataBase.Add(5, new PlayerInfo("Raphael", "De Santos", 1984));
			dataBase.Add(6, new PlayerInfo("Donatello", "Bertolucci", 1937));
			
			foreach (int key in dataBase.Keys)
			{
				comboBox.Items.Add(key);
			}
			

		}

		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			PlayerInfo playerInfo = dataBase[(int)comboBox.SelectedItem];
			nameTextBox.Text = playerInfo.PlayerName + " " + playerInfo.PlayerLastName;
			yearTextBox.Text = playerInfo.Year.ToString();
		}
	}
}
