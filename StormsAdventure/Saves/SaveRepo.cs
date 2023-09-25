using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;
//Der skal nok laves en controller class, som kan kontrollere hvad outputtet er og ligende inden der sendes data videre.
//Stormy :) :) Hvis du ser dette arbejde og tænker det kunne jeg godt give et skud på er du velkommen, jeg bruger dette som dokumentation: 
//https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
//Mit virker nok ikke pt, har ikke testet det. Syntes det kunne være en sjov ide at lave til dit spil, men se hvad du selv syntes.
//Igså da jaeeer :) <3
namespace StormsAdventure.Saves
{
    public class SaveRepo //Det virker nok ikke statig ikke blevet testet.
                         //Stormy :)
    {

        private List<string> saves = new List<string>();

        public List<string> ReadSave(int save)
        {
            string line;

            if (save == 1)
            {
                StreamReader reader = new StreamReader("..\\..\\..\\Saves\\Save-1.txt");
                line = reader.ReadLine();
                while (line != null)
                {
                    saves.Add(line);
                    line = reader.ReadLine();
                }
                return saves;
                reader.Close();
                Console.ReadLine();
            }
            else if (save == 2)
            {
                StreamReader reader = new StreamReader("..\\..\\..\\Saves\\Save-2.txt");
                line = reader.ReadLine();
                while (line != null)
                {
                    saves.Add(line);
                    line = reader.ReadLine();
                }
                return saves;
                reader.Close();
                Console.ReadLine();
            }
            else if (save == 3)
            {
                StreamReader reader = new StreamReader("..\\..\\..\\Saves\\Save-1.txt");
                line = reader.ReadLine();
                while (line != null)
                {
                    saves.Add(line);
                    line = reader.ReadLine();
                }
                return saves;
                reader.Close();
                Console.ReadLine();
            }
            return null;

        }

        public void WriteSave(int save, string name, int stamina, int health)
        {
            if (save == 1)
            {
                StreamWriter writer = new StreamWriter("..\\..\\..\\Saves\\Save-1.txt");
                writer.WriteLine(name);
                writer.WriteLine(stamina);
                writer.WriteLine(health);
                writer.Close();
                Console.WriteLine("Content have been saved to Save-1");
            }
            else if (save == 2)
            {
                StreamWriter writer = new StreamWriter("..\\..\\..\\Saves\\Save-2.txt");
                writer.WriteLine(name);
                writer.WriteLine(stamina);
                writer.WriteLine(health);
                writer.Close();
                Console.WriteLine("Content have been saved to Save-2");

            }
            else if (save == 3)
            {
                StreamWriter writer = new StreamWriter("..\\..\\..\\Saves\\Save-3.txt");
                writer.WriteLine(name);
                writer.WriteLine(stamina);
                writer.WriteLine(health);
                writer.Close();
                Console.WriteLine("Content have been saved to Save-3");

            }
            else
            {
                Console.WriteLine("Content did not save");
            }
        }
    }
}
