using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal7
{
    public class T7String
    {
        public int CharPosition
        {
            get;
            set;
        }

        public List<T7Char> Characters
        {
            get;
            set;
        }

        public bool Peek()
        {
            return this.CharPosition < this.Characters.Count;
        }

        public T7Char GetNextChar()
        {
            int buffer = this.CharPosition;
            this.CharPosition++;
            return this.Characters[buffer];
        }

        public void Write()
        {
            foreach(T7Char character in this.Characters)
            {
                character.Write();
            }
        }

        public void WriteLine()
        {
            Console.Write("\n");
            this.Write();
        }

        public void SetForegroundColor(ConsoleColor newColor)
        {
            foreach(T7Char character in this.Characters)
            {
                character.ForegroundColor = newColor;
            }
        }

        public void SetBackgroundColor(ConsoleColor newColor)
        {
            foreach(T7Char character in this.Characters)
            {
                character.BackgroundColor = newColor;
            }
        }

        public void SetColors(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            this.SetForegroundColor(foregroundColor);
            this.SetBackgroundColor(backgroundColor);
        }

        public override string ToString()
        {
            string output = "";

            foreach (T7Char character in this.Characters)
            {
                output += character.ToString();
            }

            return output;
        }

        public T7String GetFormattedLines(int lineWidth, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            string originalString = this.ToString();
            string[] lines = originalString.Split('\n');

            for(int i = 0; i < lines.Length; i++)
            {
                while(lines[i].Length < lineWidth)
                {
                    lines[i] += " ";
                }
            }

            string finalString = "";
            foreach(string line in lines)
            {
                finalString += line;
            }

            return new T7String(finalString, foregroundColor, backgroundColor);
        }

        public T7String(List<T7Char> characters)
        {
            this.Characters = characters;
            this.CharPosition = 0;
        }

        public T7String(string characterString)
        {
            char[] characterArray = characterString.ToCharArray();
            List<T7Char> newList = new List<T7Char>();

            foreach(char character in characterArray)
            {
                newList.Add(new T7Char(character));
            }

            this.Characters = newList;
            this.CharPosition = 0;
        }

        public T7String(string characterString, ConsoleColor foregroundColor, ConsoleColor backgroundColor) : this(characterString)
        {
            this.SetColors(foregroundColor, backgroundColor);
        }

        public T7String() : this(new List<T7Char>())
        {

        }
    }
}
