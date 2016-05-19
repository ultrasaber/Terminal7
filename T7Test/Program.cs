using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal7;

namespace T7Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.WindowWidth = 80;

            Console.BufferHeight = 40;
            Console.BufferWidth = 80;

            Console.CursorVisible = false;
            Console.Title = "Heavenspire";

            T7Label title = new T7Label(new T7String(" H E A V E N S P I R E ", ConsoleColor.White, ConsoleColor.Black), true, 25, 3, ConsoleColor.White, ConsoleColor.Black, 27, 10);
            title.BorderForegroundColor = ConsoleColor.DarkBlue;
            title.Draw();

            T7Label statusBar = new T7Label(new T7String(" John  HP:127  MP:127  Invulnerable\n Rose  HP:127  MP:127  Invulnerable\n Dave  HP:127  MP:127  Invulnerable\n Jade  HP:127  MP:127  Invulnerable", ConsoleColor.White, ConsoleColor.Black), true, 79, 6, ConsoleColor.White, ConsoleColor.Black, 0, 34);
            statusBar.BorderForegroundColor = ConsoleColor.DarkBlue;
            statusBar.HeaderText = new T7String("[ Party Status ]", ConsoleColor.Gray, ConsoleColor.Black);
            statusBar.Draw();

            List<T7String> testMenuOptions = new List<T7String>();
            testMenuOptions.Add(new T7String("* New Game", ConsoleColor.White, ConsoleColor.Black));
            testMenuOptions.Add(new T7String("* Continue", ConsoleColor.White, ConsoleColor.Black));
            testMenuOptions.Add(new T7String("* Clear Data", ConsoleColor.White, ConsoleColor.Black));
            testMenuOptions.Add(new T7String("* Quit", ConsoleColor.White, ConsoleColor.Black));
            T7Menu testMenu = new T7Menu(testMenuOptions, true, 25, 6, ConsoleColor.White, ConsoleColor.Black, 27, 13);
            testMenu.BorderForegroundColor = ConsoleColor.DarkBlue;
            testMenu.HeaderText = new T7String("[ Main Menu ]", ConsoleColor.Gray, ConsoleColor.Black);
            Console.Write(testMenu.GetChoice());

            T7Label continueMessage = new T7Label(new T7String(" Press any key to continue...", ConsoleColor.White, ConsoleColor.Black), true, 79, 3, ConsoleColor.White, ConsoleColor.Black, 0, 0);
            continueMessage.BorderForegroundColor = ConsoleColor.DarkGray;
            continueMessage.Draw();

            Console.ReadKey();
        }
    }
}
