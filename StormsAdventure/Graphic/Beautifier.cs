using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Graphic
{
    public static class Beautifier
    {


        public static void CoolWrite(string color, string text)
        {
            AnsiConsole.MarkupLine($"[{color}] {text} [/]");
        }

        public static void CoolBar(int health, int stamina)
        {
            AnsiConsole.Write(new BarChart()
                .Width(60)
                .Label("[green bold underline]Your stats[/]")
                .CenterLabel()
                .AddItem("Health", health, Color.Red)
                .AddItem("Stamina", stamina, Color.Yellow1));
        }

    }
}
