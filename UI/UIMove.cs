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
        public Action<int> Dialog { get; set; }
        public Action<Extension.Lut> GetPredmet { get; set; }
        public Action<IHero> GotoFight { get; set; }

        public void SetCollision(TypeGameObject data)
        {

        }

        IHero _enemy = null;
        public void FightMenu(IHero enemy)
        {
            btnFight.Enabled = true;
            _enemy = enemy;
        }

        int _dialog=0;
        public void DialogMenu(int number)
        {
            btnTalk.Enabled = true;
            _dialog = number;
        }

        private async void StepHero(object sender, EventArgs e)
        {
            btnTalk.Enabled = false;
            btnFight.Enabled = false;

            (sender as Button).Enabled = false;

            Goto((Extension.TypeMove)Enum.Parse(
                typeof(Extension.TypeMove), (sender as Button).Tag.ToString()));


            await Task.Delay(GameSettings.StepDelay);
            (sender as Button).Enabled = true;
        }



        private void btnFight_Click(object sender, EventArgs e)
        {
            GotoFight?.Invoke(_enemy);
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            Dialog?.Invoke(_dialog);
        }
    }
}
