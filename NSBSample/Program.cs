using System;
using System.Threading;
using static System.Console;

namespace NSBSample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo key = ReadKey();
                WriteLine();

                if (key.Key != ConsoleKey.Enter)
                {
                    return;
                }

                Guid id = Guid.NewGuid();

                WriteLine($"Processing order {id.ToString("D")}.");
                Thread.Sleep(3000);
                WriteLine($"Order {id.ToString("D")} has been processed!");
            }
        }
    }
}
