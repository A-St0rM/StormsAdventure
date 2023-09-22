using StormsAdventure.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Stuff
{
    public static class LootTable
    {
        //Storm har lavet min udgave af en lootTable, vi bruger ikke denne klasse den, skal kun bruges som inspiration, husk det nu, ikke noget med at kopiere. :)
        //Roger that Hr. Jensen
        //Okay Fru. Storm
        private static bool isInitialize;

        private static List<Items> lootTable;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }

            lootTable = new List<Items>();

            if (!isInitialize)
            {

                Items cookie = new Items("Cookie", 10);
                Items apple = new Items("Apple", 5);
                Items mushroom = new Items("Mushroom", 10);
                lootTable.Add(cookie);
                lootTable.Add(apple);
                lootTable.Add(mushroom);


                isInitialize = true;
            }



        }

        public static Items GetLoot()
        {
            Random rnd = new Random();

            int num = rnd.Next(0, lootTable.Count + 1);

            return lootTable[num];
        }
    }
}
