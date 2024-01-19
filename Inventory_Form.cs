using NewGame.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewGame
{
	public partial class Inventory_Form : Form
	{
		List<InventoryItem> First_inventoryItems = new List<InventoryItem>();
		List<InventoryItem> Second_inventoryItems = new List<InventoryItem>();
		List<InventoryItem> Third_inventoryItems = new List<InventoryItem>();
		public Inventory_Form()
		{
			InitializeComponent();
		}
		private void All_First_Items()
		{
			First_inventoryItems.Add(First_Helmet());
			First_inventoryItems.Add(First_Armour());
			First_inventoryItems.Add(First_Legs());
			First_inventoryItems.Add(First_Boots());
			First_inventoryItems.Add(First_Gun());
		}

		private InventoryItem First_Gun()
		{
			return new InventoryItem("Орудие", "Ржавое", 0, 5, "first_gun.png");
		}

		private InventoryItem First_Boots()
		{
			return new InventoryItem("Ботинки", "Ржавые", 2, 0, "first_boots.png");
		}

		private InventoryItem First_Legs()
		{
			return new InventoryItem("Штаны", "Ржавые", 3, 0, "first_legs.png");

		}

		private InventoryItem First_Armour()
		{
			return new InventoryItem("Нагрудник", "Ржавый", 4, 0, "first_armour.png");

		}

		private InventoryItem First_Helmet()
		{
			return new InventoryItem("Шлем", "Ржавый", 2, 0, "first_helmet.png");
		}

		private void All_Second_Items()
		{
			Second_inventoryItems.Add(Second_Helmet());
			Second_inventoryItems.Add(Second_Armour());
			Second_inventoryItems.Add(Second_Legs());
			Second_inventoryItems.Add(Second_Boots());
			Second_inventoryItems.Add(Second_Gun());
		}

		private InventoryItem Second_Gun()
		{
			return new InventoryItem("Орудие", "Железное", 0, 8, "second_gun.png");
		}

		private InventoryItem Second_Boots()
		{
			return new InventoryItem("Ботинки", "Железные", 4, 0, "second_boots.png");
		}

		private InventoryItem Second_Legs()
		{
			return new InventoryItem("Штаны", "Железные", 5, 0, "second_legs.png");
		}

		private InventoryItem Second_Armour()
		{
			return new InventoryItem("Нагрудник", "Железный", 6, 0, "second_armour.png");
		}

		private InventoryItem Second_Helmet()
		{
			return new InventoryItem("Шлем", "Железный", 4, 0, "second_helmet.png");
		}


		private void All_Third_Items()
		{
			Third_inventoryItems.Add(Third_Helmet());
			Third_inventoryItems.Add(Third_Armour());
			Third_inventoryItems.Add(Third_Legs());
			Third_inventoryItems.Add(Third_Boots());
			Third_inventoryItems.Add(Third_Gun());

		}
		private InventoryItem Third_Gun()
		{
			return new InventoryItem("Орудие", "Железное", 0, 11, "third_gun.png");
		}

		private InventoryItem Third_Boots()
		{
			return new InventoryItem("Ботинки", "Железные", 6, 0, "third_boots.png");
		}

		private InventoryItem Third_Legs()
		{
			return new InventoryItem("Штаны", "Железные", 7, 0, "third_legs.png");
		}

		private InventoryItem Third_Armour()
		{
			return new InventoryItem("Нагрудник", "Железный", 8, 0, "third_armour.png");
		}

		private InventoryItem Third_Helmet()
		{
			return new InventoryItem("Шлем", "Железный", 6, 0, "third_helmet.png");
		}

		
	}
}
