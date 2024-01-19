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

            positon = new Point(pictMap.Width / 2, pictMap.Height / 2);
            
            hero = new Bitmap(path);
            blank = new Bitmap(pathBlank);
            
            map.DrawImage(hero, positon);
            pictMap.Image =new Bitmap( canvas);
        }

        async Task GoUp()
        {
            Point next = new Point(0, -hero.Height);
            //CheckPixel(next);
            
            await Task.Delay(GameSettings.StepDelay);
            map.DrawImage(blank, positon);
            positon.Offset(new Point(0, -hero.Height));
            map.DrawImage(hero, positon);
            pictMap.Image = canvas;
        }

        private void CheckPixel(Point next)
        {
            try
            {
                var color = level_map.GetPixel(next.X, next.Y);
                if (color != null)
                {
                    switch (color.ToArgb())
                    {
                        case 345:
                            break;
                        default:
                            break;
                    }
                }
            }
            catch { }
        }

        async Task GoDown()
        {
            Point next = new Point(0, -hero.Height);
            //CheckPixel(next);

            await Task.Delay(GameSettings.StepDelay);
            map.DrawImage(blank, positon);
            positon.Offset(new Point(0, hero.Height));
            map.DrawImage(hero, positon);
            pictMap.Image = canvas;
        }

        async Task GoRight()
        {
            Point next = new Point(0, -hero.Height);
            //CheckPixel(next);

            await Task.Delay(GameSettings.StepDelay);
            map.DrawImage(blank, positon);
            positon.Offset(new Point(hero.Width, 0));
            map.DrawImage(hero, positon);
            pictMap.Image = canvas;
        }

        async Task GoLeft()
        {
            Point next = new Point(0, -hero.Height);
            //CheckPixel(next);

            await Task.Delay(GameSettings.StepDelay);
            map.DrawImage(blank, positon);
            positon.Offset(new Point(-hero.Width, 0));
            map.DrawImage(hero, positon);
            pictMap.Image = canvas;
        }
    }
}
