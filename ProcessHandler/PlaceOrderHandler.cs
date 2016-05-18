using System;
using System.Threading;
using NServiceBus;
using Sample.Contracts;

namespace ProcessHandler
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        private IBus _bus;

        public PlaceOrderHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(PlaceOrder message)
        {
            Console.WriteLine("Placing Order...");
            Console.WriteLine($"Order {message.Id} Placed!");
            _bus.Publish(new OrderPlaced { Id = message.Id });
        }
    }
}
