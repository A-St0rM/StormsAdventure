using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Character
{
    public class Inventory
    {
        private List<string> inventory = new List<string>();

        public Inventory(IEnumerable<string> initialItems = null)
        {
            if (initialItems != null)
            {
                inventory.AddRange(initialItems);
            }
        }

        public void Display_Inventory()
        {
            Console.WriteLine("\tThis is your inventory");
            foreach (var item in inventory)
            {
                Console.WriteLine(item);
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
