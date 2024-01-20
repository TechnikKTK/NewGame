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
    public partial class MainMenu_Form : Form
    {
        public MainMenu_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Test.Test().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inventory_Form inventory = new Inventory_Form();
            inventory.Show();
        }
    }
}
