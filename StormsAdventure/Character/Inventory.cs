using StormsAdventure.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Character
{
    public static class Inventory
    {
        private static bool isInitialize;

        private static List<Items> inventory;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }
            inventory = new List<Items>();

            if (inventory.Count == 0)
            {
                Items cookie = new Items("Cookie", 10);
                Items apple = new Items("Apple", 5);
                Items mushroom = new Items("Mushroom", 10);
                inventory.Add(cookie);
                inventory.Add(apple);
                inventory.Add(mushroom);
                isInitialize = true;
            }

        }

        public static void Display_Inventory()
        {
            Console.WriteLine("\tThis is your inventory");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory[i].Name + " || " + inventory[i].Item_stat);
            }
        }

        public static void AddToInventory(Items item)
        {
            inventory.Add(item); 
        }

        public static void RemoveFromInventory(Items item)
        {
            inventory.Remove(item);
            
        }
    }
}
