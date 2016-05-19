using System;
using NServiceBus;
using Sample.Contracts;

namespace ShipOrderHandler
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        public void Handle(OrderPlaced message)
        {
            Console.WriteLine($"Shipping order {message.Id.ToString("D")}!");
        }
    }
}