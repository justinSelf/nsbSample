using System;
using NServiceBus;

namespace Sample.Contracts
{
    public class PlaceOrder : ICommand
    {
        public Guid Id { get; set; }
    }
}
