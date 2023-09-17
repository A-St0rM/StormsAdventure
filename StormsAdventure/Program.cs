using StormsAdventure.Start;
//using StormsAdventure.Start.Game_Start;

namespace StormsAdventure
{
    public class Program
    {
        static void Main(string[] args)
        {

            Game_Start start = new Game_Start();

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
                    start.StartGame();

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