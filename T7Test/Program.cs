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
            Console.WindowHeight = Console.LargestWindowHeight - 10;
            Console.WindowWidth = Console.LargestWindowWidth - 10;

            T7Console.DrawBox(10, 5, ConsoleColor.Black, ConsoleColor.DarkYellow);
            T7Console.DrawBox(8, 3, ConsoleColor.Black, ConsoleColor.Yellow, 1, 1);
            T7Console.DrawBox(6, 1, ConsoleColor.White, ConsoleColor.Black, 2, 2);

            Console.ResetColor();
            Console.Write('═');
            Console.Write('╔');
            Console.Write('╚');
            Console.Write('╗');
            Console.Write('╝');
            Console.Write('║');

            T7Console.DrawBox(25, 25, ConsoleColor.White, ConsoleColor.Red, 20, 15);

            T7String testString = new T7String("hello world", ConsoleColor.White, ConsoleColor.Blue);

            while(testString.Peek())
            {
                testString.GetNextChar().Write();
                Console.Write("\n");
            }
            Console.WriteLine(testString.ToString());

            Console.ResetColor();
            T7Label testLabel = new T7Label(new T7String("hello world", ConsoleColor.Green, ConsoleColor.Magenta), false, 8, 10, ConsoleColor.Red, ConsoleColor.White, 60, 5);
            testLabel.Draw();

            Console.ResetColor();
            T7Label testLabel2 = new T7Label(new T7String("* Enter town\n* Don't"), true, 40, 4, ConsoleColor.White, ConsoleColor.Magenta, 30, 30);
            testLabel2.BorderForegroundColor = ConsoleColor.Blue;
            testLabel2.Draw();

            Console.ReadKey();
        }
    }
}
