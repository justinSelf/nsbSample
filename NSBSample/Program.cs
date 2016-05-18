using System;
using NServiceBus;
using Sample.Contracts;

namespace NSBSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = Bus.CreateSendOnly(new BusConfiguration());
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                if (key.Key != ConsoleKey.Enter)
                {
                    return;
                }
                Guid id = Guid.NewGuid();

                PlaceOrder command = new PlaceOrder
                {
                    Id = id
                };

                bus.Send(command);

                Console.WriteLine($"Sent a new PlaceOrder message with id: {id.ToString("N")}");

            }
        }
    }
}
