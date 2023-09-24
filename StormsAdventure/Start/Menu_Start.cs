using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Start
{
    public static class Menu_Start
    {

        public static void Menu()
        {

            bool state = true;

            while (state == true)
            {

                Console.Clear();
                Console.WriteLine("Welcome to Storm's RPG game");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1 - Start the game");
                Console.WriteLine("2 - Exit the game");

                string playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    Console.Clear();
                    state = false;
                    Intro.Game_Intro();


                }
                else if (playerChoice == "2")
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
