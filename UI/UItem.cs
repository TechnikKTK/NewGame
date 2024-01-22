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
    public partial class UItem : UserControl
    {
        InventoryItem _item;

        Graphics cloud;
        Bitmap image = new Bitmap(60, 60);

        public UItem()
        {
            InitializeComponent();
        }

        public event Action<InventoryItem> Apply;

        public UItem(InventoryItem item)
        {
            InitializeComponent();
            _item = item;
            image = new Bitmap(item.Image);
            cloud = Graphics.FromImage(image);

            if (!item.IsVisible)
            {
                cloud.FillRectangle(
                    new SolidBrush(Color.FromArgb(150, Color.Gray)),
                    new RectangleF(new Point(0, 0), new Size(60, 60)));
            }

            pictureBox1.Image = image;
        }

        public void Update(bool state)
        {
            image = new Bitmap(_item.Image);
            cloud = Graphics.FromImage(image);

            _item.IsVisible = state;
            if (!_item.IsVisible)
            {
                cloud.FillRectangle(
                    new SolidBrush(Color.FromArgb(150, Color.Gray)),
                    new RectangleF(new Point(0, 0), new Size(60, 60)));
            }

            pictureBox1.Image = image;
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Apply?.Invoke(_item);
        }
    }
}

