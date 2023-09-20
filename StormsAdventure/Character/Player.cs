using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using StormsAdventure.Stuff;
using StormsAdventure.Character;

namespace StormsAdventure.Start
{
    public static class Player
    {
        
        public static int health { get; set; }

        public static int stamina { get; set; }

        private static bool isInitialize;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }
            else
            {
                isInitialize = true;
                health = 100;
                stamina = 100;
            }

        }

        public static void Display_Stats()
        {
            Console.WriteLine("Stamina: " + stamina + " Health " + health);
        }

        public static void Tick_Stamina()
        {
            stamina = stamina - 10;
        }

        public static void Eat(Items food)
        {

            if (food.Name == "cookie")
            {
                stamina += food.Item_stat;
            }
            else if (food.Name == "apple")
            {
                stamina += food.Item_stat;
            }
            else if (food.Name == "mushroom")
            {
                stamina -= food.Item_stat;
            }
        }



    }


}
