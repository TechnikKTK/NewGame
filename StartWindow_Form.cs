using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame
{
	public partial class StartWindow_Form : Form
	{
		public StartWindow_Form()
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
			lblHeading.Font = new Font(font.Families[0], 23);	
			btnStart.Font = new Font(font.Families[0], 23);
			btnSettings.Font = new Font(font.Families[0], 23);
			btnExit.Font = new Font(font.Families[0], 23);
		}

        private void btnStart_Click(object sender, EventArgs e)
        {
			MainForm frm = new MainForm();
			frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
