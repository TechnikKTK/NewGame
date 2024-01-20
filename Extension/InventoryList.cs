using System.Collections.Generic;

namespace NewGame.Extension
{
    public class InventoryList
    {
        public List<InventoryItem> FirstType = new List<InventoryItem>();
        public List<InventoryItem> TwoType = new List<InventoryItem>();
        public List<InventoryItem> ThreeType = new List<InventoryItem>();

        public static InventoryList Instance = new InventoryList();
        protected InventoryList()
        {
            FirstType.AddRange(GetDefences(InventoryType.First));
            TwoType.AddRange(GetDefences(InventoryType.Two));
            ThreeType.AddRange(GetDefences(InventoryType.Three));
        }

        private InventoryItem[] GetDefences(InventoryType type)
        {
            if (type == InventoryType.First)
            {
                return new InventoryItem[]
                {
                    new InventoryItem(type, InventoryClass.Sward, "меч1",0,10),
                    new InventoryItem(type, InventoryClass.Helmet, "шлем1",1,0),
                    new InventoryItem(type, InventoryClass.Body, "броня1",1,0),
                    new InventoryItem(type, InventoryClass.Legs, "ноги1",1,0),
                    new InventoryItem(type, InventoryClass.Boots, "сапоги1",1,0),
                };
            }
            else if (type == InventoryType.Two)
            {
                return new InventoryItem[]
                {
                    new InventoryItem(type, InventoryClass.Sward, "меч2",0,20),
                    new InventoryItem(type, InventoryClass.Helmet,  "шлем2",2,0),
                    new InventoryItem(type, InventoryClass.Body, "броня2",2,0),
                    new InventoryItem(type, InventoryClass.Legs,"ноги2",2,0),
                    new InventoryItem(type, InventoryClass.Boots,"сапоги2",2,0),
                };
            }
            else
            {
                return new InventoryItem[]
                {
                    new InventoryItem(type, InventoryClass.Sward, "меч3",0,30),
                    new InventoryItem(type, InventoryClass.Helmet,  "шлем3",3,0),
                    new InventoryItem(type, InventoryClass.Body, "броня3",3,0),
                    new InventoryItem(type, InventoryClass.Legs, "ноги3",3,0),
                    new InventoryItem(type, InventoryClass.Boots,"сапоги3",3,0),
                };
            }
        }
    }
}