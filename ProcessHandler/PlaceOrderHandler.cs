using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using Sample.Contracts;

namespace ProcessHandler
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public void Handle(PlaceOrder message)
        {
            Console.WriteLine("Placing Order...");
            Console.WriteLine("Order {0} Placed!", message.Id);
        }
    }
}
