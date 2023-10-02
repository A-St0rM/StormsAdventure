using Spectre.Console;
using StormsAdventure.Character;
using StormsAdventure.Graphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Start
{
    public static class Control
    {
        public static void Controls() //Should popup when the player needs to do something
        {
            bool state = true;

            while (state == true)
            {

                //Made a new menu system, so we can iteract with it.
                var playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .Title("What do u want to do?\n ---------------------------")
                    .PageSize(6)
                    .AddChoices("See your stats", "Move", "See your inventory", "See your weapon", "Exit the game"));


                //Console.WriteLine("What do u want to do?");
                //Console.WriteLine("---------------------------");
                //Console.WriteLine("1 - See your stats");
                //Console.WriteLine("2 - Move");
                //Console.WriteLine("3 - See your inventory");
                //Console.WriteLine("4 - See your weapon");
                //Console.WriteLine("5 - Exit the game");

                //string playerChoice = Console.ReadLine();

                if (playerChoice == "See your stats") //See stats
                {
                    Player.Display_Stats();

                }
                else if (playerChoice == "Move") //Move Command
                {
                    Run.Game_Tick();
                    state = false;

                }
                else if (playerChoice == "See your inventory") //Inventory
                {
                    Inventory.Display_Inventory();

                }
                else if (playerChoice == "See your weapon")
                {
                    WeaponSlot.DisplayCurrentWeapon();

                }
                else if (playerChoice == "Exit the game") //Exit
                {
                    state = false;
                    Console.Clear();
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("U entered a wrong value plz try agian");
                    Console.Clear();
                }

            }
        }
    }
}
