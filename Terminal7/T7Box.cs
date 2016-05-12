using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal7
{
    public class T7Box
    {
        public int PositionX
        {
            get;
            set;
        }

        public int PositionY
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public ConsoleColor ForegroundColor
        {
            get;
            set;
        }

        public ConsoleColor BackgroundColor
        {
            get;
            set;
        }

        public virtual void Draw()
        {
            Console.CursorTop = this.PositionY;

            for(int y = 0; y < this.Height; y++)
            {
                Console.CursorLeft = this.PositionX;

                string row = "";
                for(int i = 0; i < this.Width; i++)
                {
                    row += " ";
                }
                row += "\n";

                T7String output = new T7String(row, this.ForegroundColor, this.BackgroundColor);
                output.Write();
            }
        }

        public T7Box(int width, int height, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int xpos = 0, int ypos = 0)
        {
            this.PositionX = xpos;
            this.PositionY = ypos;
            this.Width = width;
            this.Height = height;
            this.ForegroundColor = foregroundColor;
            this.BackgroundColor = backgroundColor;
        }

        public T7Box(int width, int height) : this(width, height, Console.ForegroundColor, Console.BackgroundColor)
        {

        }

        public T7Box(int width, int height, int xpos, int ypos) : this(width, height, Console.ForegroundColor, Console.BackgroundColor, xpos, ypos)
        {

        }
    }
}
