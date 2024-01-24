using NewGame.Extension;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NewGame.UI
{
    public partial class ProgressData : UserControl
    {
        public ProgressData()
        {
            InitializeComponent();
        }

        IHero _person;
        TypeProgress _type;

        public void Initialize(IHero person, TypeProgress type, bool isEnemy = false)
        {
            _person = person;
            _type = type;
            var path = "";
            switch (_type)
            {
                case TypeProgress.Health:
                    panel1.BackColor = Color.Red;
                    path = Path.Combine(GameSettings.AppPath, GameSettings.ImagesPath, "heart.png");
                    break;
                case TypeProgress.Damage:
                    panel1.BackColor = Color.Blue;
                    path = Path.Combine(GameSettings.AppPath, GameSettings.ImagesPath, "damage.png");
                    break;
                case TypeProgress.Protect:
                    panel1.BackColor = Color.Green;
                    path = Path.Combine(GameSettings.AppPath, GameSettings.ImagesPath, "protect.png");
                    break;
            }

            pictureBox1.Image = new Bitmap(path);
            pictureBox3.Image = new Bitmap(path);

            pictureBox3.Visible = isEnemy;
            pictureBox1.Visible = !isEnemy;

            UpdateProgress();
        }

        public void UpdateProgress()
        {
            if (_person != null)
            {
                switch( _type )
                {
                    case TypeProgress.Health:
                        panel1.Width = _person.Health* 255 / 100;
                        break;
                    case TypeProgress.Damage:
                        panel1.Width = _person.Damage * 255 / 5;
                        break;
                    case TypeProgress.Protect:
                        panel1.Width = _person.Protect * 255 / 5;
                        break;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

    public enum TypeProgress
    {
        Health,
        Damage,
        Protect

    }
}
