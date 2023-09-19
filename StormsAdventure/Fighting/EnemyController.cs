using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Fighting
{
    public class EnemyController
    {
        private List<Enemy> bosses;
        private List<Enemy> enemies;

        public EnemyController()
        {
            enemies = new List<Enemy>();
            bosses = new List<Enemy>();
            Enemy enemy1 = new Enemy("Goblin", 5, 20);
            Enemy enemy2 = new Enemy("Begger", 1, 10);
            Enemy enemy3 = new Enemy("Holigan", 10, 32);
            Enemy enemy4 = new Enemy("Cashier", 8, 19);
            Enemy enemy5 = new Enemy("Acquaintance", 7, 27);
            enemies.Add(enemy1); 
            enemies.Add(enemy2);
            enemies.Add(enemy3);
            enemies.Add(enemy4);
            enemies.Add(enemy5);

        }

        public Enemy Enemy_Pick()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 4);
            return enemies[num];
        }


    }
}
