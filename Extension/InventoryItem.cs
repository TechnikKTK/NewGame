using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame.Extension
{
    internal class InventoryItem
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public int Defense { get; set; }
        public int Damage { get; set; }

        public Bitmap Image { get; set; }
        public InventoryItem(string type, string name, int defense, int damage, string image = null)
        {
            Type = type;
            Name = name;
            Defense = defense;
            Damage = damage;
            if (image != null)
            {
                Image = new Bitmap(Path.Combine(GameSettings.AppPath, GameSettings.ResourcesPath, image));
            }
        }
    }    
}
