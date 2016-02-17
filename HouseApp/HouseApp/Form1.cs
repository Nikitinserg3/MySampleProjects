using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseApp
{
	public partial class Form1 : Form
	{
		int Moves;

		private Location _currentLocation;

		private RoomWithHidingPlace _diningRoom;
		private RoomWithDoor _livingRoom;
		private RoomWithDoor _kitchen;
		private Room _stairs;
		private RoomWithHidingPlace _hallway;
		private RoomWithHidingPlace _bathroom;
		private RoomWithHidingPlace _masterBedroom;
		private RoomWithHidingPlace _secondBedroom;

		private OutsideWithDoor _frontYard;
		private OutsideWithDoor _backYard;
		private OutsideWithHidingPlace _garden;
		private OutsideWithHidingPlace _driveway;

		private Opponent _opponent;



		public Form1()
		{
			InitializeComponent();
			CreateObjects();
			_opponent = new Opponent(_frontYard);
			ResetGame(false);

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		internal void CreateObjects()
		{
			_livingRoom = new RoomWithDoor("Гостинная", "старинный ковер", "дубовая дверь с латунной ручкой", "в гардеробе");
			_diningRoom = new RoomWithHidingPlace("Столовая", "хрустальная люстра", "в высоком шкафу");
			_kitchen = new RoomWithDoor("Кухня", "приборы из нержавеющей стали", "в сундуке", "сетчатая дверь");
			_stairs = new Room("Лестница", "деревянные перила");
			_hallway = new RoomWithHidingPlace("Верхний коридор", "картина с собакой", "в гардеробе");
			_bathroom = new RoomWithHidingPlace("Ванная", "раковина и туалет", "в душе");
			_masterBedroom = new RoomWithHidingPlace("Главная спальня", "большая кровать", "под кроватью");
			_secondBedroom = new RoomWithHidingPlace("Вторая спальня", "маленькая кровать", "под кроватью");
			_garden = new OutsideWithHidingPlace("Сад", false, "в сарае");
			_frontYard = new OutsideWithDoor("Лужайка", false, "тяжелая дубовая дверь");
			_backYard = new OutsideWithDoor("Задний двор", true, "сетчатая дверь");
			_driveway = new OutsideWithHidingPlace("Подъезд", true, "в гараже");



			_livingRoom.Exits = new Location[] { _stairs, _diningRoom };
			_diningRoom.Exits = new Location[] { _livingRoom, _kitchen };
			_kitchen.Exits = new Location[] { _diningRoom };
			_stairs.Exits = new Location[] { _livingRoom, _hallway };
			_hallway.Exits = new Location[] { _stairs, _masterBedroom, _secondBedroom, _bathroom };
			_masterBedroom.Exits = new Location[] { _hallway };
			_secondBedroom.Exits = new Location[] { _hallway };
			_bathroom.Exits = new Location[] { _hallway };
			_driveway.Exits = new Location[] { _frontYard, _backYard };
			_frontYard.Exits = new Location[] { _backYard, _garden, _driveway };
			_garden.Exits = new Location[] { _frontYard, _backYard };
			_backYard.Exits = new Location[] { _frontYard, _garden, _driveway };


			_backYard.DoorLocation = _kitchen;
			_livingRoom.DoorLocation = _frontYard;
			_kitchen.DoorLocation = _backYard;
			_frontYard.DoorLocation = _livingRoom;


		}

		internal void MoveToANewLocation(Location newLocation)
		{
			Moves++;
			_currentLocation = newLocation;
			RedrawForm();
		}

		private void RedrawForm()
		{
			exitsComboBox.Items.Clear();

			for (int i = 0; i < _currentLocation.Exits.Length; i++)
			{
				exitsComboBox.Items.Add(_currentLocation.Exits[i].Name);
			}

			exitsComboBox.SelectedIndex = 0;

			descriptionTextBox.Text = _currentLocation.Description + "\r\n(перемещение №" + Moves + ")";
			if (_currentLocation is IHidingPlace)
			{
				IHidingPlace hidingPlace = _currentLocation as IHidingPlace;
				checkButton.Text = "Check " + hidingPlace.HidingPlaceName;
				checkButton.Visible = true;
			}
			else
			{
				checkButton.Visible = false;
			}
			if (_currentLocation is IHaveExteriorDoor)
			{
				goThroughTheDoorButton.Visible = true;
			}
			else
			{
				goThroughTheDoorButton.Visible = false;
			}
		}


		private void goHereButton_Click(object sender, EventArgs e)
		{
			MoveToANewLocation(_currentLocation.Exits[exitsComboBox.SelectedIndex]);
			if (_currentLocation is IHidingPlace)
			{
				checkButton.Visible = true;
				checkButton.Text = "Check " + ((IHidingPlace)_currentLocation).HidingPlaceName;
			}
			else
			{
				checkButton.Visible = false;
			}

		}

		private void goThroughTheDoorButton_Click(object sender, EventArgs e)
		{
			IHaveExteriorDoor hasDoor = _currentLocation as IHaveExteriorDoor;
			MoveToANewLocation(hasDoor.DoorLocation);
		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			Moves++;
			if (_opponent.Check(_currentLocation))
			{
				ResetGame(true);
			}
			else
			{
				RedrawForm();
			}
		}

		private void hideButton_Click(object sender, EventArgs e)
		{
			hideButton.Visible = false;
			for (int i = 1; i <= 10; i++)
			{
				_opponent.Move();
				descriptionTextBox.Text = i + " ";
				Application.DoEvents();
				Thread.Sleep(200);
			}

			descriptionTextBox.Text = "Я иду искать.";
			Application.DoEvents();
			Thread.Sleep(500);
			goHereButton.Visible = true;
			exitsComboBox.Visible = true;
			MoveToANewLocation(_livingRoom);
		}

		private void ResetGame(bool displayMessage)
		{
			if (displayMessage)
			{
				MessageBox.Show("Меня нашли за " + Moves + " ходов.");
				IHidingPlace foundLocation = _currentLocation as IHidingPlace;
				descriptionTextBox.Text = "Соперник найден за " + Moves + " ходов. Он прятался " + foundLocation.HidingPlaceName + ".";
			}
			Moves = 0;
			hideButton.Visible = true;
			goHereButton.Visible = false;
			checkButton.Visible = false;
			goThroughTheDoorButton.Visible = false;
			exitsComboBox.Visible = false;
		}
	}
}
