using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using StormsAdventure.Character;
using StormsAdventure.Stuff;
//using StormsAdventure.Levels;

namespace StormsAdventure.Start
{
    public static class Intro
    {

        public static void Game_Intro()
        {
            House house = new House();
            Console.WriteLine("The sun poured through my window. Another day had dawned. Storm walks down the stairs");
            Console.WriteLine("Mom: Good morning Storm");
            Console.WriteLine("Storm: Morning Mom");

            Console.WriteLine("Mom: We are in need of bananas for the banana cake. Do you mind going to the grocery store?");
            Console.WriteLine("Pick an answer: ");


            bool state = true;

            while (state == true)
            {

                var playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                    .PageSize(3)
                    .AddChoices("Sure, i can do that", "Nah, actually not"));


                //Console.WriteLine("1 - Storm: Sure, i can do that");
                //Console.WriteLine("2 - Storm: Nah, actually not");

                //int Playerchoice = Convert.ToInt32(Console.ReadLine());

                if (playerChoice == "Sure, i can do that")
                {
                    Console.WriteLine("Storm: Sure, i can do that");
                    state = false;
                    Console.Clear();
                    house.Start_House();
                    break;
                }
                else if (playerChoice == "Nah, actually not")
                {
                    Console.WriteLine("Storm: Nah, actually not"); // Need to fix the text, disseapers instantly
                    Console.WriteLine("RIP Alissa Storm");
                    Console.WriteLine("Cause of death: Mom with Shahata");

                    Menu_Start.Menu();
                }
            }
                              
        }

    }
}
