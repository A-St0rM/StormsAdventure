using StormsAdventure.Character;
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
                Console.WriteLine("What do u want to do?");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1 - See your stats");
                Console.WriteLine("2 - Move");
                Console.WriteLine("3 - See your inventory");
                Console.WriteLine("4 - Exit the game");

                string playerChoice = Console.ReadLine();

                if (playerChoice == "1") //See stats
                {
                    Player.Display_Stats();

                }
                else if (playerChoice == "2") //Move Command
                {
                    Run.Game_Tick();
                    state = false;

                }
                else if (playerChoice == "3") //Inventory
                {
                    Inventory.Display_Inventory();

                }
                else if (playerChoice == "4") //Exit
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
