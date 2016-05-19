using System;
using System.Threading;

namespace NSBSample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                if (key.Key != ConsoleKey.Enter)
                {
                    return;
                }

                Guid id = Guid.NewGuid();

                Console.WriteLine($"Placing order: {id.ToString("N")}");
                Thread.Sleep(3000);
                Console.WriteLine($"Order {id.ToString("N")} placed!");
            }
        }
    }
}
