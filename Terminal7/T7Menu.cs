using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal7
{
    public class T7Menu : T7Label
    {
        public int SelectedIndex
        {
            get;
            set;
        }

        public List<T7String> MenuOptions
        {
            get;
            set;
        }

        public override void Draw()
        {
            base.Draw();
            Console.CursorTop = this.PositionY + 1;

            foreach(T7String choice in this.MenuOptions)
            {
                Console.CursorLeft = this.PositionX + 1;

                if(MenuOptions.IndexOf(choice) == this.SelectedIndex)
                {
                    new T7String(choice.ToString(), ConsoleColor.Black, ConsoleColor.White).Write();
                }
                else
                {
                    choice.Write();
                }
                new T7Char('\n', this.ForegroundColor, this.BackgroundColor).Write();
            }
        }

        public int GetChoice()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

            while(keyInfo.Key != ConsoleKey.Enter)
            {
                if(keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if(this.SelectedIndex > 0)
                    {
                        this.SelectedIndex--;
                    }
                }
                else if(keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (this.SelectedIndex < this.MenuOptions.Count - 1)
                    {
                        this.SelectedIndex++; 
                    }
                }
                this.Draw();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Black;
                keyInfo = Console.ReadKey();
            }

            return this.SelectedIndex;
        }

        public T7Menu(List<T7String> menuOptions, bool hasBorders, int width, int height, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int xpos, int ypos) : 
            base(new T7String(), hasBorders, width, height, foregroundColor, backgroundColor, xpos, ypos)
        {
            this.SelectedIndex = 0;
            this.MenuOptions = menuOptions;
        }
    }
}
