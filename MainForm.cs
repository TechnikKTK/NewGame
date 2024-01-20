﻿using NewGame.Extension;
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
    public partial class MainForm : Form
    {
        IHero hero = new Hero();
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Inventory_Form inventory = new Inventory_Form();
            inventory.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            uiMap1.Initialize();
            uiMap1.SetEvent(uiMove1.SetCollision);
            uiMove1.Goto += uiMap1.MoveHero;

            progressData1.Initialize(hero, UI.TypeProgress.Health);
            progressData2.Initialize(hero, UI.TypeProgress.Damage);
            progressData3.Initialize(hero, UI.TypeProgress.Protect);
        }
    }
}
