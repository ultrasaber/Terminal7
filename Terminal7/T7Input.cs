using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal7
{
    public class T7Input : T7Label
    {
        public string GetInput()
        {
            this.Draw();
            Console.CursorLeft = this.PositionX + 1;
            Console.CursorTop = this.PositionY + this.Height - 2;
            T7Console.Write(">", this.ForegroundColor, this.BackgroundColor);

            Console.CursorVisible = true;
            string input = Console.ReadLine();
            Console.CursorVisible = false;
            return input;
        }

        public T7Input(T7String text, bool hasBorders, int width, int height, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int xpos = 0, int ypos = 0) : 
            base(text, hasBorders, width, height, foregroundColor, backgroundColor, xpos, ypos)
        {

        }
    }
}
