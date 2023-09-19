using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Start
{
    public class Run
    {
        Player player = new Player(100, 100);

        public void Game_Run() //For things witch need to tick when the game runs
        {
            player.Tick_Stamina();
        }

        public void stats()
        {
            player.Display_Stats();
        }
    }
}
