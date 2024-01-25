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
        bool _isEnemy = false;
        public void Initialize(IHero person, TypeProgress type, bool isEnemy = false)
        {
            _person = person;
            _type = type;
            _isEnemy = isEnemy;
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
                int coeff = 1;
                int max = 255;
                int offset = panel1.Width;
                int value = 1;

                switch (_type)
                {

                    case TypeProgress.Health:
                        coeff = 100;
                        value = _person.Health;
                        break;
                    case TypeProgress.Damage:
                        coeff = 5;
                        value = _person.Damage;
                        break;
                    case TypeProgress.Protect:
                        coeff = 5;
                        value = _person.Protect;
                        break;
                }

                panel1.Width = max * value / coeff;
                
                if(_isEnemy)
                {
                    var point = panel1.Location;
                    point.Offset(offset - panel1.Width, 0);
                    panel1.Location = point;
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
