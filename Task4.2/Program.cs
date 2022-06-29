using System;

namespace Task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int helthBar = 8;
            int maxHealthBar = 10;
            int manaBar = 6;
            int maxManaBar = 10;
            int position = 0;
            DrawBar(helthBar, maxHealthBar, ConsoleColor.Red, 0);
            position++;
            DrawBar(manaBar, maxManaBar, ConsoleColor.Blue, position);
        }

        static void DrawBar(int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += " ";
            }

            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }

            Console.Write(bar + "]\n");
        }
    }
}
