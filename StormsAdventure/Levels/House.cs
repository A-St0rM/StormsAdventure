using StormsAdventure.Fighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Start
{
    public class House
    {
        Game_Start start = new Game_Start();
        Combat Combat = new Combat();

        public void Start_House()
        {
            Console.WriteLine("You are in a house");
            //Combat.Start_Combat();
            DownStairs();
        }


        public void DownStairs()
        {
            Console.WriteLine("You are currently in the kitchen");
            Console.WriteLine("The front door is on your left and the living room is straight ahead");
            start.Controls();
            
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine(" 1 - Forward");
            Console.WriteLine(" 2 - Front door");
           
            bool state = true;

            while(state == true)
            {
              int PlayerChoice = Convert.ToInt32(Console.ReadLine());

                if(PlayerChoice == 1) // We are in the living room
                {
                    Console.WriteLine("You see all your siblings watching TV");

                }
                else if (PlayerChoice == 2) // Front door
                {
                    Console.WriteLine("You finally stepped out of the house and starting your journey!");
                    Console.WriteLine("Mom has packed Cookies and apples for you so you dont get tired on your way!");
                    Console.WriteLine("Make sure to check your backpack when you get tired ;)");
                }
                else
                {
                    Console.WriteLine("You entered a wrong value plz try agian");
                }



            }

        }   
        public void LivingRoom()
        {
            Console.WriteLine("You are watching TV with ur siblings. The front door is now on right side and the kitchen straight forward");
            start.Controls();
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine(" 1 - Forward");
            Console.WriteLine(" 2 - Front door");

            bool State = true;
            int PlayerChoice = Convert.ToInt32(Console.ReadLine());

            while(State == true)
            {
                if(PlayerChoice == 1)
                {
                    Console.WriteLine("You are in the kitchen again dumbass!");
                    Console.WriteLine("_____________________________________");
                    DownStairs();
                }

                else if (PlayerChoice == 2)
                {
                    Console.WriteLine("You finally stepped out of the house and starting your journey!");
                    Console.WriteLine("Mom has packed Cookies and apples for you so you dont get tired on your way!");
                    Console.WriteLine("Make sure to check your backpack when you get tired ;)");
                }
                else
                {
                    Console.WriteLine("You entered a wrong value plz try agian");
                }







            }



        }

    }
}
