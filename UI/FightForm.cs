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

namespace FightForm
{
    public partial class FightForm : Form
    {
        public FightForm()
        {
            InitializeComponent();
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
			btnFight.Font = new Font(font.Families[0], 35);	
			btnGiveUp.Font = new Font(font.Families[0], 23);
			btnProtect.Font = new Font(font.Families[0], 23);
		}
    }
}
