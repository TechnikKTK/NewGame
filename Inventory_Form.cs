using NewGame.Extension;
using System;
using System.Windows.Forms;


namespace NewGame
{
    public partial class Inventory_Form : Form
    {
        public Inventory_Form()
        {
            InitializeComponent();
        }

        public event Action<bool> UpdateInventory;


        private void Inventory_Form_Load(object sender, EventArgs e)
        {
            foreach (var item in InventoryList.Instance.FirstType)
            {
                var elem = new UI.UItem(item); 
                elem.Apply += Applyelement;
                UpdateInventory += elem.Update;
                flowLayoutPanel1.Controls.Add(elem);
            }

            foreach (var item in InventoryList.Instance.TwoType)
            {
                var elem = new UI.UItem(item);
                elem.Apply += Applyelement;
                UpdateInventory += elem.Update;

                flowLayoutPanel1.Controls.Add(elem);
            }

            foreach (var item in InventoryList.Instance.ThreeType)
            {
                var elem = new UI.UItem(item);
                elem.Apply += Applyelement;
                UpdateInventory += elem.Update;

                flowLayoutPanel1.Controls.Add(elem);
            }
        }

        private void Applyelement(InventoryItem item)
        {
            if (!item.IsVisible) return;
           
            switch (item.Class)
            {
                case InventoryClass.Sward:
                    zoneHand.Image = item.Image;
                    stHand.Text = item.Damage.ToString();
                    break;
                case InventoryClass.Helmet:
                    zoneHelmet.Image = item.Image;
                    defHelmet.Text = item.Defense.ToString();
                    break;
                case InventoryClass.Body:
                    zoneBody.Image = item.Image;
                    defBody.Text = item.Defense.ToString();
                    break;
                case InventoryClass.Legs:
                    zoneLegs.Image = item.Image;
                    defLegs.Text = item.Defense.ToString();
                    break;
                case InventoryClass.Boots:
                    zoneBoots.Image = item.Image;
                    defBoots.Text = item.Defense.ToString();
                    break;
                default:
                    break;
            }
            Calcucate();
        }

        private void Calcucate()
        {
            int i1 = int.Parse(defHelmet.Text);
            int i2 = int.Parse(defBody.Text);
            int i3 = int.Parse(defLegs.Text);
            int i4 = int.Parse(defBoots.Text);

            allAtack.Text = stHand.Text;
            allProtect.Text = (i1 + i2 + i3 + i4).ToString();
        }
    }
}