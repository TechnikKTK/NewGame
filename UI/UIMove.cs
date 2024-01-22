using NewGame.Extension;
using System;
using System.Drawing.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame.UI
{
    public partial class UIMove : UserControl, IGameControl
    {
        public UIMove()
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
            }

        }

        public Action<Extension.TypeMove> Goto { get; set; }
        public Action<Extension.NpcTalk> Talk { get; set; }
        public Action<Extension.Lut> GetPredmet { get; set; }
        public Action<int> Fight { get; set; }

        public void SetCollision(TypeGameObject data)
        {

        }

        private async void StepHero(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;

            Goto((Extension.TypeMove)Enum.Parse(
                typeof(Extension.TypeMove), (sender as Button).Tag.ToString()));

            await Task.Delay(GameSettings.StepDelay);
            (sender as Button).Enabled = true;
        }
    }
}
