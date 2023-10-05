using StormsAdventure.Start;
using Spectre.Console;
using StormsAdventure.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

                Items empty_slot = new Items("Empty_Slot", 0);

                for (int i = 0; i < 10 - inventory.Count; i++)
                {
                    inventory.Add(empty_slot);
                }

                isInitialize = true;
            }

        }

        public static void Display_Inventory()
        {

            Console.WriteLine("This is your inventory");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine(inventory[i].Name + " || " + inventory[i].Item_stat);
            }
            bool inv_State = true;
            while (inv_State == true)
            {
                //Made a new menu system, so we can iteract with it.
                var player_Answer = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("Do you want to use anything from your inventroy\n ---------------------------")
                    .PageSize(3)
                    .AddChoices("yes", "no"));


                //Console.WriteLine("Do you want to use anything from your inventroy");
                //Console.WriteLine("Yes / No");
                //string player_Answer = Console.ReadLine();

                if (player_Answer == "yes")
                {
                    bool player_state = true;

                    while (player_state == true)
                    {
                        var inv_index = AnsiConsole.Prompt(new SelectionPrompt<string>()
                            .Title("Choose what u want from your inventory \n ---------------------------")
                            .PageSize(7)
                            .AddChoices(inventory[0].Name, inventory[1].Name, inventory[2].Name, inventory[3].Name, inventory[4].Name, inventory[5].Name, inventory[6].Name));

                        if (inv_index == "Empty_Slot")
                        {
                            Console.Clear();
                            AnsiConsole.MarkupLine("[red]U dont have anything in that slot[/]"); //this can add color to your text
                            player_state = true;
                        }
                        else if(inv_index != "Empty_Slot")
                        {
                            int index = inventory.FindIndex(item => item.Name == inv_index);
                            PickFromInventory(inventory[index]);
                            player_state = false;
                        }
                        

                    }
                    inv_State = false;
                    Console.Clear();
                }
                else if (player_Answer == "no")
                {
                    inv_State = false;
                    Console.Clear();
                }
            }

        }

        public static void AddToInventory(Items item)
        {

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].Name == "Empty_Slot")
                {
                    inventory.Add(item);
                }
            }
        }

        private static void PickFromInventory(Items item)
        {

            Player.Eat(item);
            inventory.Remove(item);
            Items empty_slot = new Items("Empty_Slot", 0);
            inventory.Add(empty_slot);

        }
    }
}
