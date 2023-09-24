using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Saves
{
    public class SaveRepo
    {
        //Der skal nok laves en controller class, som kan kontrollere hvad outputtet er og ligende inden der sendes data videre.
        //Stormy :) :) Hvis du ser dette arbejde og tænker det kunne jeg godt give et skud på er du velkommen, jeg bruger dette som dokumentation: 
        //https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
        //Mit virker nok ikke pt, har ikke testet det. Syntes det kunne være en sjov ide at lave til dit spil, men se hvad du selv syntes.
        //Igså da jaeeer :) <3
        public string ReadSave(int save) 
        {
            string line;
            try
            {
                if (save == 1)
                {
                    StreamReader reader = new StreamReader("//Save-1");
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        return line;
                    }
                    reader.Close();
                    Console.ReadLine();
                }
                else if (save == 2)
                {
                    StreamReader reader = new StreamReader("//Save-2");
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        return line;
                    }
                    reader.Close();
                    Console.ReadLine();
                }
                else if (save == 3)
                {
                    StreamReader reader = new StreamReader("//Save-3");
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        return line;
                    }
                    reader.Close();
                    Console.ReadLine();
                }
                return null;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("Executing finally block.");//Skal sku nok ændres hehe
            }

        }

        public string WriteSave()
        {
            return null;
        }



    }
}
