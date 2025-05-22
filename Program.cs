using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;
        int height = 15;
        Random rand = new Random();

        while (true)
        {
            Console.Clear();
            for (int i = 0; i < height; i++)
            {
                int spaces = height - i;
                Console.SetCursorPosition(spaces, i + 1);

                for (int j = 0; j < i * 2 + 1; j++)
                {
                    
                    // 1 из 5 символов будет "мигать"
                    char c = rand.Next(5) == 0 ? '*' : '.';
                    if (c == '*')
                    {
                         Console.ForegroundColor = GetRandomColor(rand);
                    }else
                    {
                         Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(c);
                }
                Console.ResetColor();
            }

            Console.SetCursorPosition(height, height + 1);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("||");
            Console.ResetColor();

            Thread.Sleep(300);
        }
    }

    static ConsoleColor GetRandomColor(Random rand)
    {
        ConsoleColor[] colors = {
            ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow,
            ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Magenta,
            ConsoleColor.White
        };
        return colors[rand.Next(colors.Length)];
    }
}
