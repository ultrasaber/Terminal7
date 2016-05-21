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



            T7Label statusBar = new T7Label(new T7String(" John  HP:███▒▒▒▒▒▒▒  MP:███▒▒▒▒▒▒▒  Invulnerable\n Rose  HP:███▒▒▒▒▒▒▒  MP:███▒▒▒▒▒▒▒  Invulnerable\n Dave  HP:███▒▒▒▒▒▒▒  MP:███▒▒▒▒▒▒▒  Invulnerable\n Jade  HP:███▒▒▒▒▒▒▒  MP:███▒▒▒▒▒▒▒  Invulnerable", ConsoleColor.Green, ConsoleColor.Black), true, 79, 6, ConsoleColor.White, ConsoleColor.Black, 0, 34);
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

            T7Input inputMock = new T7Input(new T7String("", ConsoleColor.White, ConsoleColor.Black), true, 40, 3, ConsoleColor.White, ConsoleColor.Black, ypos:10);
            inputMock.HeaderText = new T7String("[ Input Box ]", ConsoleColor.White, ConsoleColor.Black);
            inputMock.BorderForegroundColor = ConsoleColor.DarkBlue;
            inputMock.GetInput();

            T7Label continueMessage = new T7Label(new T7String(" Press any key to exit...", ConsoleColor.White, ConsoleColor.Black), true, 79, 3, ConsoleColor.White, ConsoleColor.Black, 0, 0);
            continueMessage.BorderForegroundColor = ConsoleColor.DarkGray;
            continueMessage.Draw();

            Console.ReadKey();
        }
    }
}
