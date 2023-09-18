using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Character
{
    public class Inventory
    {
        private List<string> inventory;

        public Inventory()
        {
            inventory = new List<string>();

            if (inventory.Count == 0)
            {
                inventory.Add("Cookie");
                inventory.Add("Shield");
                inventory.Add("Potion");
            }
        }

        public void Display_Inventory()
        {
            Console.WriteLine("\tThis is your inventory");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory[i]);
            }
        }

        public void AddToInventory(string item)
        {
            inventory.Add(item); 
        }

        public void RemoveFromInventory(string item)
        {
            inventory.Remove(item);
            
        }
    }
}
