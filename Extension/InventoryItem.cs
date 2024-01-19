using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame.Extension
{
    internal class InventoryItem
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }  

        public Bitmap Image { get; set; }

    }
}
