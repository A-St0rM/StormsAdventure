using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Graphic
{
    public static class Ascii_Art
    {

        private static string house = "  _    _                      \r\n | |  | |                     \r\n | |__| | ___  _   _ ___  ___ \r\n |  __  |/ _ \\| | | / __|/ _ \\\r\n | |  | | (_) | |_| \\__ \\  __/\r\n |_|  |_|\\___/ \\__,_|___/\\___|\r\n                              \r\n                              ";

        private static string forest = "  ______                  _   \r\n |  ____|                | |  \r\n | |__ ___  _ __ ___  ___| |_ \r\n |  __/ _ \\| '__/ _ \\/ __| __|\r\n | | | (_) | | |  __/\\__ \\ |_ \r\n |_|  \\___/|_|  \\___||___/\\__|\r\n                              \r\n                              ";

        private static string gameStart = "   _____ _                                         _                 _                  \r\n  / ____| |                               /\\      | |               | |                 \r\n | (___ | |_ ___  _ __ _ __ ___  ___     /  \\   __| |_   _____ _ __ | |_ _   _ _ __ ___ \r\n  \\___ \\| __/ _ \\| '__| '_ ` _ \\/ __|   / /\\ \\ / _` \\ \\ / / _ \\ '_ \\| __| | | | '__/ _ \\\r\n  ____) | || (_) | |  | | | | | \\__ \\  / ____ \\ (_| |\\ V /  __/ | | | |_| |_| | | |  __/\r\n |_____/ \\__\\___/|_|  |_| |_| |_|___/ /_/    \\_\\__,_| \\_/ \\___|_| |_|\\__|\\__,_|_|  \\___|\r\n                                                                                        \r\n                                                                                        ";


        public static void Ascii_GameStart()
        {
            Console.WriteLine(gameStart);
        }

        public static void Ascii_House()
        {
            Console.WriteLine(house);
        }

        public static void Ascii_Forest()
        {
            Console.WriteLine(forest);
        }

        //Im telling you man. I learn Unreal engine and then bam bam we have graphic. TRUST ;)
    }
}
