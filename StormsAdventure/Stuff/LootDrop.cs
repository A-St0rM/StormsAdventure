using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Stuff
{
    public static class Lootdrop
    {

        private static bool isInitialize; // Is automatically false when given no value for a bool variable

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
                Items burgir = new Items("burgir", 20);
                Items bolognese = new Items("bolognese", 25);
                lootTable.Add(cookie);
                lootTable.Add(burgir);
                lootTable.Add(bolognese);


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
