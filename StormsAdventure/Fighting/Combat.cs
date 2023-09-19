using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StormsAdventure.Character;
using StormsAdventure.Start;

namespace StormsAdventure.Fighting
{
    public class Combat
    {

        public void Start_Combat()
        {
            EnemyController enemyController = new EnemyController();
            Enemy enemy;
            int player_Health;
            enemy = enemyController.Enemy_Pick();
            Console.WriteLine(enemy.Name);

            //do
            //{
            //    Console.WriteLine("Select your action");
                

            //}
            //while (player_Health > 0 || enemy.Enemy_Health > 0);

        }




    }
}
