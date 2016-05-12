using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal7
{
    public class T7Char
    {
        public char Character
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

        public override string ToString()
        {
            return this.Character.ToString();
        }

        public void Write()
        {
            Console.ForegroundColor = this.ForegroundColor;
            Console.BackgroundColor = this.BackgroundColor;
            Console.Write(this.Character);
        }

        public T7Char(char character, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            this.Character = character;
            this.ForegroundColor = foregroundColor;
            this.BackgroundColor = backgroundColor;
        }

        public T7Char(char character) : 
            this(character, Console.ForegroundColor, Console.BackgroundColor) { }
    }
}
