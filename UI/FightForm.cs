using NewGame.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame
{
    public partial class FightForm : Form
    {
        IHero _hero;
        IHero _enemy;

        public FightForm()
        {
            InitializeComponent();

			fontsProjects();
			fonts();
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
			//Задаем шрифт текста, отображаемого элементом управления.
			btnFight.Font = new Font(font.Families[0], 23);	
			btnGiveUp.Font = new Font(font.Families[0], 23);
			btnProtect.Font = new Font(font.Families[0], 23);
		}

        public void InitializeFight(IHero hero, IHero enemy)
        {
            _hero = hero;
            _enemy = enemy;

            heroHealth.Initialize(_hero, NewGame.UI.TypeProgress.Health);
            heroDamage.Initialize(_hero, NewGame.UI.TypeProgress.Damage);
            heroProtect.Initialize(_hero, NewGame.UI.TypeProgress.Protect);
            
            enemyHealth.Initialize(_enemy, NewGame.UI.TypeProgress.Health,true);
            enemyDamage.Initialize(_enemy, NewGame.UI.TypeProgress.Damage, true);
            enemyProtect.Initialize(_enemy, NewGame.UI.TypeProgress.Protect, true);

            _hero.Update += heroHealth.UpdateProgress;
            _enemy.Update += enemyHealth.UpdateProgress;
            _hero.Update += UpdateProgress;
            _enemy.Update += UpdateProgress;
        }

        private void UpdateProgress()
        {
            if(_enemy.IsAlive && _hero.IsAlive)
            {
                return;
            }
            else
            {
                this.Close();
                if(_hero.IsAlive)
                {
                    MessageBox.Show("Враг повержен!!!");
                }
            }
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            _hero.Atack(_enemy);
        }

        private void btnProtect_Click(object sender, EventArgs e)
        {

        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
