using System.Windows.Forms;

namespace NewGame.Test
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {    
            uiMap1.Initialize();
            uiMap1.SetEvent(uiMove1.SetCollision);
            uiMove1.Goto += uiMap1.MoveHero;
        }
    }
}
