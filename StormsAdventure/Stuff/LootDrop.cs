using StormsAdventure.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Stuff
{


    public static class LootDrop
    {
        private static bool IsInitialize;
        private static List<Items> lootdrop;

        public static void Initialize()
        {
            lootdrop = new List<Items>();

            if (IsInitialize)
            {
                return;
            }
           

            if (!IsInitialize)
            {
                Items cookie = new Items("Cookie", 10);
                Items burgir = new Items("Burgir", 20);
                Items bolognese = new Items("Bolognese", 30);
                lootdrop.Add(cookie);
                lootdrop.Add(burgir);
                lootdrop.Add(bolognese);
            }
        }

        public static Items GetLoot() //Add some text
        {
            Random random = new Random();

            int num = random.Next(0, lootdrop.Count);

            return lootdrop[num];
        }


        

        

      

        


        


        



    }
}
