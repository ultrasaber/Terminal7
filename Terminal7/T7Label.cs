using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal7
{
    public class T7Label : T7Box
    {
        public T7String Text
        {
            get;
            set;
        }

        public T7String HeaderText
        {
            get;
            set;
        }

        public bool HasBorders
        {
            get;
            set;
        }

        public ConsoleColor BorderForegroundColor
        {
            get;
            set;
        }

        public ConsoleColor BorderBackgroundColor
        {
            get;
            set;
        }

        public override void Draw()
        {
            Console.CursorTop = this.PositionY;
            T7String formattedLines;

            if(this.Text.ToString().Split('\n').Length > 1)
            {
                if (this.HasBorders)
                {
                    formattedLines = this.Text.GetFormattedLines(this.Width - 2, this.ForegroundColor, this.BackgroundColor);
                }
                else
                {
                    formattedLines = this.Text.GetFormattedLines(this.Width, this.ForegroundColor, this.BackgroundColor);
                }
            }
            else
            {
                formattedLines = this.Text;
            }


            for (int y = 0; y < this.Height; y++)
            {
                Console.CursorLeft = this.PositionX;
                this.HeaderText.CharPosition = 0;

                T7String output = new T7String(new List<T7Char>());
                for (int i = 0; i < this.Width; i++)
                {
                    if(this.HasBorders && (y == 0 || y == this.Height - 1))
                    {
                        if(y == 0 && i == 0)
                        {
                            output.Characters.Add(new T7Char('╔', this.BorderForegroundColor, this.BorderBackgroundColor));
                        }
                        else if(y == 0 && i == this.Width-1)
                        {
                            output.Characters.Add(new T7Char('╗', this.BorderForegroundColor, this.BorderBackgroundColor));
                        }
                        else if(y == this.Height-1 && i == 0)
                        {
                            output.Characters.Add(new T7Char('╚', this.BorderForegroundColor, this.BorderBackgroundColor));
                        }
                        else if(y == this.Height-1 && i == this.Width-1)
                        {
                            output.Characters.Add(new T7Char('╝', this.BorderForegroundColor, this.BorderBackgroundColor));
                        }
                        else
                        {
                            if(y == 0 && this.HeaderText.Peek())
                            {
                                output.Characters.Add(this.HeaderText.GetNextChar());
                            }
                            else
                            {
                                output.Characters.Add(new T7Char('═', this.BorderForegroundColor, this.BorderBackgroundColor));
                            }
                        }
                    }
                    else if(this.HasBorders && (i == 0 || i == this.Width - 1))
                    {
                        output.Characters.Add(new T7Char('║', this.BorderForegroundColor, this.BorderBackgroundColor));
                    }
                    else if(formattedLines.Peek())
                    {
                        output.Characters.Add(formattedLines.GetNextChar());
                    }
                    else
                    {
                        output.Characters.Add(new T7Char(' ', this.ForegroundColor, this.BackgroundColor));
                    }
                }

                if(y < this.Height - 1)
                {
                    output.Characters.Add(new T7Char('\n'));
                }
                
                output.Write();
            }
        }

        public T7Label(T7String text, bool hasBorders, int width, int height, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int xpos = 0, int ypos = 0) :
            base(width, height, foregroundColor, backgroundColor, xpos, ypos)
        {
            this.Text = text;
            this.HasBorders = hasBorders;
            this.BorderForegroundColor = foregroundColor;
            this.BorderBackgroundColor = backgroundColor;
            this.HeaderText = new T7String(new List<T7Char>());
        }
    }
}
