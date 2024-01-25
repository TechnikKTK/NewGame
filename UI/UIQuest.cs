using NewGame.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace NewGame.UI
{
    public partial class UIQuest : UserControl
    {
        public UIQuest()
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
                    item.Font = new Font(font.Families[0], 16);
                }
                if (item is TextBox)
                {
                    item.Font = new Font(font.Families[0], 18);
                }
            }
        }

        public void ShowDialog(int number)
        {
            var path = Path.Combine(GameSettings.AppPath, GameSettings.DialogPath, $"{number}.txt");
            textBox1.Text = File.ReadAllText(path);
        }

        public void ShowEnemy(IHero enemy)
        {
            textBox1.Text = "Пришло время сразится.. Бери свой меч и вперед!!";
        }

        public void ShowLut()
        {
            textBox1.Text = "Что за сундук? Интересно что там внутри...";
        }
    }
}
