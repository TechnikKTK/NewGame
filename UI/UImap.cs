using NewGame.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace NewGame.UI
{
    public partial class UIMap : UserControl, IMapControl
    {
        Graphics map;
        Bitmap canvas;
        Bitmap level_map;
        
        Point positon;
        Bitmap hero;
        Bitmap blank;

        public event Action<TypeGameObject> OnCollision;

        public UIMap()
        {
            InitializeComponent();
        }

        public async void MoveHero(TypeMove move)
        {
            switch(move) 
            {
                case TypeMove.Left:
                    await GoLeft();
                    break;
                case TypeMove.Up:
                    await GoUp();
                    break;
                case TypeMove.Right:
                    await GoRight();
                    break;
                case TypeMove.Down:
                    await GoDown();
                    break;
            }
        }

        public void SetEvent(Action<TypeGameObject> _onCollision)
        { OnCollision += _onCollision; }

        public async void Initialize()
        {
            canvas = new Bitmap(pictMap.Width, pictMap.Height);

            await Task.Delay(1000);

            map = Graphics.FromImage(canvas);
            var path = Path.Combine(GameSettings.AppPath, GameSettings.ImagesPath, "hero.png");
            var pathBlank = Path.Combine(GameSettings.AppPath, GameSettings.ImagesPath, "blank.png");
            var pathLevel = Path.Combine(GameSettings.AppPath, GameSettings.ImagesPath, "map.png");

            positon = new Point(pictMap.Width / 2, pictMap.Height / 2);

            hero = new Bitmap(path);
            level_map = new Bitmap(pathLevel);
            blank = new Bitmap(pathBlank);
            
            map.DrawImage(hero, positon);
            pictMap.Image =new Bitmap( canvas);
        }

        async Task GoUp()
        {
            Point next = new Point(positon.X, positon.Y - hero.Height);
            var color = CheckPixel(next);
            if (color.Name == "ffffffff")
            {

                await Task.Delay(GameSettings.StepDelay);
                map.DrawImage(blank, positon);
                positon.Offset(new Point(0, -hero.Height));
                map.DrawImage(hero, positon);
            }
            else
            {
                map.FillRectangle(new SolidBrush(color), new Rectangle(next, new Size(10, 10)));
            }
            pictMap.Image = canvas;

        }

        private Color CheckPixel(Point next)
        {
            return level_map.GetPixel(next.X, next.Y);
        }

        async Task GoDown()
        {
            Point next = new Point(positon.X, positon.Y + hero.Height);
            var color = CheckPixel(next);
            if (color.Name == "ffffffff")
            {

                await Task.Delay(GameSettings.StepDelay);
                map.DrawImage(blank, positon);
                positon.Offset(new Point(0, hero.Height));
                map.DrawImage(hero, positon);
            }
            else
            {
                map.FillRectangle(new SolidBrush(color), new Rectangle(next, new Size(10, 10)));
            }
            pictMap.Image = canvas;

        }

        async Task GoRight()
        {
            Point next = new Point(positon.X + hero.Width, positon.Y);
            var color = CheckPixel(next);
            if (color.Name == "ffffffff")
            {
                await Task.Delay(GameSettings.StepDelay);
                map.DrawImage(blank, positon);
                positon.Offset(new Point(hero.Width, 0));
                map.DrawImage(hero, positon);
            }
            else
            {
                map.FillRectangle(new SolidBrush(color), new Rectangle(next, new Size(10, 10)));
            }
            pictMap.Image = canvas;

        }

        async Task GoLeft()
        {
            Point next = new Point(positon.X - hero.Width, positon.Y);
            var color = CheckPixel(next);
            if (color.Name == "ffffffff")
            {
                await Task.Delay(GameSettings.StepDelay);
                map.DrawImage(blank, positon);
                positon.Offset(new Point(-hero.Width, 0));
                map.DrawImage(hero, positon);
            }
            else
            {
                map.FillRectangle(new SolidBrush(color), new Rectangle(next, new Size(10,10)));
            }
            pictMap.Image = canvas;

        }
    }
}
