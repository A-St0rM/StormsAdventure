using StormsAdventure.Start;
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
                Console.WriteLine(i + " || " + inventory[i].Name + " || " + inventory[i].Item_stat);
            }
            bool  inv_State = true;
            while (inv_State == true)
            {
                Console.WriteLine("Do you want to use anything from your inventroy");
                Console.WriteLine("Yes / No");
                string player_Answer = Console.ReadLine();

                if (player_Answer.ToLower() == "yes")
                {
                    Console.WriteLine("Choose what index from your inventory you want :)");
                    int inventory_Index = Convert.ToInt32(Console.ReadLine());

                    PickFromInventory(inventory[inventory_Index]);

                    inv_State = false;
                    Console.Clear();
                }
                else if (player_Answer.ToLower() == "no")
                {
                    inv_State = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Pla write the corret answer");
                }
            }

        }

        public static void AddToInventory(Items item)
        {
            inventory.Add(item); 
        }

        private static void PickFromInventory(Items item)
        {
            Player.Eat(item);
            inventory.Remove(item);
        }
    }
}
