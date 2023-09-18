using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace StormsAdventure.Start
{
    public class Player
    {
        
        public int health { get; set; }

        public int stamina { get; set; }

        public Player(int health, int stamina)
        {
            this.health = health;
            this.stamina = stamina;
        }

        public void Display_Stats()
        {
            Console.WriteLine("Stamina: " + stamina + " Health " + health);
        }

        public void Tick_Stamina()
        {
            stamina = stamina - 10;
        }

        public void Eat(string food)
        {
            int cookie = 5;
            int apple = 10;
            int mushroom = -10;

            if (food == "cookie")
            {
                stamina = stamina + cookie;
            }
            else if (food == "apple")
            {
                stamina = stamina + apple;
            }
            else if (food == "mushroom")
            {
                
            }
        }



    }


}
