using System;
using NServiceBus;
using Sample.Contracts;

namespace EmailHandler
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        public void Handle(OrderPlaced message)
        {
            Console.WriteLine($"Sending email for Order {message.Id}");
        }
    }
}