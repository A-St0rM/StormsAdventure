using StormsAdventure.Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Saves
{
    public class SaveController
    {

        private List<string> strings;

        SaveRepo SaveRepo = new SaveRepo();

        public int SelectSave()
        {
            bool state = true;

            while (state == true)
            {
                Console.WriteLine("What save do u want to load from?");
                Console.WriteLine("1 - Save 1");
                Console.WriteLine("2 - Save 2");
                Console.WriteLine("3 - Save 3");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.WriteLine("U picked Save: " + answer);
                    return Convert.ToInt32(answer);
                    state = false;
                }
                else if (answer == "2")
                {
                    Console.WriteLine("U picked Save: " + answer);
                    return Convert.ToInt32(answer);
                    state = false;
                }
                else if (answer == "3")
                {
                    Console.WriteLine("U picked Save: " + answer);
                    return Convert.ToInt32(answer);
                    state = false;
                }
            }
            return 0;

        } 


        public void SaveSelected(int selectedSave)
        {
            strings = SaveRepo.ReadSave(selectedSave);

            Player.name = strings[0];
        }





    }
}
