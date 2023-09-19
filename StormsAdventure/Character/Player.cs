using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using StormsAdventure.Stuff;

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

        public int ChangeHealth(int healtch_Change)
        {
            return health - healtch_Change;
        }

        public void Tick_Stamina()
        {
            stamina = stamina - 10;
        }

        public void Eat(Items food)
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
