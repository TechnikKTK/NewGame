using NewGame.Extension;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace NewGame
{
    public partial class MainForm : Form
    {
        IHero hero = new Hero();
        public MainForm()
        {
            InitializeComponent(); fontsProjects(); fonts();
        }

        PrivateFontCollection font;
        private void fontsProjects()
        {
            //Добавляем шрифт из указанного файла в em.Drawing.Text.PrivateFontCollection
            this.font = new PrivateFontCollection();
            this.font.AddFontFile("font/myFont.ttf");
        }

        private void fonts()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Font = new Font(font.Families[0], 23);
                }
            }

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
            uiMap1.GetDialog += uiMove1.DialogMenu;
            uiMove1.Dialog += uiQuest1.ShowDialog;
            uiMap1.GetEnemy += uiQuest1.ShowEnemy;
            uiMap1.GetEnemy += uiMove1.FightMenu;
            uiMove1.Goto += uiMap1.MoveHero;

            uiMove1.GotoFight += (enemy)=>
            {
                var form = new FightForm();
                form.InitializeFight(hero, enemy);
                form.ShowDialog();
                if(hero.IsAlive)
                {
                    //перерисовка карты
                }
            };

            uiQuest1.ShowDialog(1);

            progressData1.Initialize(hero, UI.TypeProgress.Health);
            progressData2.Initialize(hero, UI.TypeProgress.Damage);
            progressData3.Initialize(hero, UI.TypeProgress.Protect);
        }
	}
}
