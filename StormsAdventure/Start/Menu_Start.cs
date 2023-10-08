using Spectre.Console;
using StormsAdventure.Graphic;
using System;
//using System.Windows.Forms.SendKeys;
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
                Ascii_Art.Ascii_GameStart();
                //Made a new menu system, so we can iteract with it.
                var playerChoice = Beautifier.CoolMenu("Welcome to Storm's RPG game", 3, "Start the game", "Exit the game");

                //Console.WriteLine("Welcome to Storm's RPG game");
                //Console.WriteLine("---------------------------");
                //Console.WriteLine("1 - Start the game");
                //Console.WriteLine("2 - Exit the game");

                //string playerChoice = Console.ReadLine();

                if (playerChoice == "Start the game")
                {
                    Console.Clear();
                    state = false;
                    Intro.Game_Intro();


                }
                else if (playerChoice == "Exit the game")
                {
                    state = false;
                    Console.Clear();
                    Environment.Exit(0);
                    //SendKeys.SendWait("{ENTER}");

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
