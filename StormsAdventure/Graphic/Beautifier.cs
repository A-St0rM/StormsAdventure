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

        public static string CoolMenu(string title, string choice1, string choice2)//Method overload for 2 choices
        {
            string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"{title}\n ---------------------------")
                .PageSize(3)
                .AddChoices(choice1, choice2));
            return playerChoice;
        }

        public static string CoolMenu(string title, string choice1, string choice2, string choice3)//Method overload for 3 choices
        {
            string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"{title}\n ---------------------------")
                .PageSize(4)
                .AddChoices(choice1, choice2, choice3));
            return playerChoice;
        }

        public static string CoolMenu(string title, string choice1, string choice2, string choice3, string choice4)//Method overload for 4 choices
        {
            string playerChoice = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title($"{title}\n ---------------------------")
                .PageSize(5)
                .AddChoices(choice1, choice2, choice3, choice4));
            return playerChoice;
        }

    }
}
