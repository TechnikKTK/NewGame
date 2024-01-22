using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace NewGame.Extension
{
    public class InventoryItem
    {
        public InventoryType Type { get; set; }
        public InventoryClass Class { get; set; }
        public string Name { get; set; }
        public bool IsVisible { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public int Defense { get; set; }
        public int Damage { get; set; }

        public Bitmap Image { get; set; }
        public InventoryItem(InventoryType type, InventoryClass inv_class, string name, int defense, int damage, string image = null)
        {
            Class = inv_class;
            Type = type;
            Name = name;
            Defense = defense;
            Damage = damage;

            if (image != null)
            {
                Image = new Bitmap(Path.Combine(GameSettings.AppPath, GameSettings.InventoryPath, image));
            }
            else if (Name.Length > 0)
            {
                try
                {

                    Image = new Bitmap(Path.Combine(GameSettings.AppPath, GameSettings.InventoryPath, Name + ".png"));
                }
                catch { }
            }
        }
    }

    public enum InventoryType
    {
        First = 0,
        Two = 1,
        Three = 2,
    }

    public enum InventoryClass
    {
        Sward = 0,
        Helmet = 1,
        Body = 2,
        Legs = 3,
        Boots = 4,
    }
}
