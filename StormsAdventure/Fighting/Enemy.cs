using StormsAdventure.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Fighting
{
    public static class Enemy
    {

        private static bool isInitialize;

        private static List<Creatures> enemies;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }
            else
            {
                Creatures enemy1 = new Creatures("Goblin", 5, 20);
                Creatures enemy2 = new Creatures("Begger", 1, 10);
                Creatures enemy3 = new Creatures("Holigan", 10, 32);
                Creatures enemy4 = new Creatures("Cashier", 8, 19);
                Creatures enemy5 = new Creatures("Acquaintance", 7, 27);
                enemies.Add(enemy1);
                enemies.Add(enemy2);
                enemies.Add(enemy3);
                enemies.Add(enemy4);
                enemies.Add(enemy5);
                isInitialize = true;
            }

        }

        public static Creatures Enemy_Pick()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 4);
            return enemies[num];
        }

        public static void 


    }
}
