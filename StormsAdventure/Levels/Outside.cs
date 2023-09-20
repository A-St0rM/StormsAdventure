using StormsAdventure.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Levels
{
    public class Outside
    {
        

        public void Start_Outside()
        {
            Forest();      
        }

        public void Forest()
        {

            Console.Write("After some time walking from your house. You reach a point where you have two options. You can either take the short cut through the forest");
            Console.WriteLine(" or take the longer way by taking the original walking path ");
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine(" 1 - Through the forest");
            Console.WriteLine(" 2 - The walking path");
            

            bool state = true;

            int PlayerChoice = Convert.ToInt32(Console.ReadLine());
          

            while (state)
            {
                if(PlayerChoice == 1)
                {               
                    Console.Write("The forest is vast and seemingly endless, with no clear paths or markers to guide your way. The deeper you venture, the more you feel cut off from the outside world, as if you've entered another dimension entirely.");
                    Console.WriteLine("");
                }
                else if (PlayerChoice == 2) 
                {

                    Console.WriteLine("");

                }
            }




        }



    }
}
