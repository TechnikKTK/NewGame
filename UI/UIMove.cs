using NewGame.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame.UI
{
    public partial class UIMove : UserControl, IGameControl
    {
        public UIMove()
        {
            InitializeComponent();
        }

        public Action<Extension.TypeMove> Goto { get; set; }
        public Action<Extension.NpcTalk> Talk { get; set; }
        public Action<Extension.Lut> GetPredmet { get; set; }
        public Action<int> Fight { get; set; }

        public void SetCollision(TypeGameObject data)
        {

        }

        private void StepHero(object sender, EventArgs e)
        {
            Goto((Extension.TypeMove)Enum.Parse(
                typeof(Extension.TypeMove), (sender as Button).Tag.ToString()));
        }
    }
}
