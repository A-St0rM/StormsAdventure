using StormsAdventure.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Stuff
{

    public class LootDrop
    {
        public string items { get; set; }

        List<LootDrop> lootdrop = new List<LootDrop>();

        LootDrop lootDrop1= new LootDrop("random item");
        LootDrop lootDrop2 = new LootDrop("random item");
        LootDrop lootDrop4 = new LootDrop("random item");
        LootDrop lootDrop5 = new LootDrop("random item");

        //LootDrop


        public LootDrop(string items)
        {
            this.items = items;
        }



    }
}
