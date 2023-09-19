using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Stuff
{
    public class Items
    {
        public string Name { get; set; }
        public int Item_stat { get; set; }

        public Items (string name, int item_stat)
        {
            Name = name;
            Item_stat = item_stat;
        }


    }
}
