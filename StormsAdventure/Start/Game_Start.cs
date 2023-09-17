using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Start
{
    public class Game_Start
    {
        //Run run = new Run();    
        //House house = new House();

        public void StartGame()
        {
            Console.WriteLine("The sun poured through my window. Another day had dawned. Storm walks down the stairs");
            Console.WriteLine("Mom: Good morning Storm");
            Console.WriteLine("Storm: Morning Mom");

            Console.WriteLine("Mom: We are in need of bananas for the banana cake. Do you mind going to the grocery store?");
            Console.WriteLine("Pick an answer: ");
            Console.WriteLine("1 - Storm: Sure, i can do that");
            Console.WriteLine("2 - Storm: Nah, actually not");


            bool state = true;

            while (state == true)
            {
                int Playerchoice = Convert.ToInt32(Console.ReadLine());

                if (Playerchoice == 1)
                {
                    Console.WriteLine("Storm: Sure, i can do that");
                    state = false;
                    Console.Clear();
                    house.Start_House();
                    break;
                }
                else if (Playerchoice == 2)
                {
                    Console.WriteLine("Storm: Nah, actually not");
                    Console.WriteLine("RIP Alissa Storm");
                    Console.WriteLine("Cause of death: Mom with Shahata");
                    //Menu();
                }
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("U entered a wrong value plz try agian");
                    Console.Clear();
                }
            }
                              
        }

        public void Controls() //Should popup when the player needs to do something
        {
            bool state = true;

            while (state == true)
            {
                Console.WriteLine("What do u want to do?");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1 - See your stats");
                Console.WriteLine("2 - See your inventory");
                Console.WriteLine("3 - Move");
                Console.WriteLine("4 - Exit the game");

                string playerChoice = Console.ReadLine();

                if (playerChoice == "1") //See stats
                {
                    //run.stats();

                }
                else if (playerChoice == "2") //Move Command
                {
                    //run.Game_Run();

                }
                else if (playerChoice == "3") //Inventory
                {
                    Console.WriteLine("This is your inventory ahah");//Do not work fix it storm

                }
                else if (playerChoice == "3") //Exit
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
