using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal7
{
    public static class T7Console
    {
        public static void Write(string output, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            T7String t7String = new T7String(output, foregroundColor, backgroundColor);
            t7String.Write();
        }

        public static void Write(string output)
        {
            T7Console.Write(output, Console.ForegroundColor, Console.BackgroundColor);
        }

        public static void DrawBox(int width, int height, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int xpos = 0, int ypos = 0)
        {
            T7Box t7Box = new T7Box(width, height, foregroundColor, backgroundColor, xpos, ypos);
            t7Box.Draw();
        }

        public static void DrawLabel(string text, bool hasBorders, int width, int height, ConsoleColor foregroundColor, ConsoleColor backgroundColor, int xpos = 0, int ypos = 0)
        {
            T7Label t7Label = new T7Label(new T7String(text, foregroundColor, backgroundColor), hasBorders, width, height, foregroundColor, backgroundColor, xpos, ypos);
            t7Label.Draw();
        }
    }
}
