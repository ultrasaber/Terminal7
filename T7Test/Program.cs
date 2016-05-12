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

            T7Label title = new T7Label(new T7String(" H E A V E N S P I R E "), true, 25, 3, ConsoleColor.White, ConsoleColor.Black, 27, 10);
            title.BorderForegroundColor = ConsoleColor.Blue;
            title.Draw();

            T7Label mainMenu = new T7Label(new T7String("* New Game\n* Continue\n* Clear Data\n* Quit"), true, 25, 6, ConsoleColor.White, ConsoleColor.Black, 27, 13);
            mainMenu.BorderForegroundColor = ConsoleColor.Blue;
            mainMenu.BorderBackgroundColor = ConsoleColor.Black;
            mainMenu.HeaderText = new T7String("Main Menu", ConsoleColor.Blue, ConsoleColor.Black);
            mainMenu.Draw();

            Console.ReadKey();
        }
    }
}
