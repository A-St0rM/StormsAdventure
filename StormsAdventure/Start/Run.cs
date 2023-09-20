using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Start
{
    public class Run
    {

        public void Game_Run() //For things witch need to tick when the game runs
        {
            Player.Tick_Stamina();
        }

        public void stats()
        {
            Player.Display_Stats();
        }
    }
}
