using System;
using NServiceBus;

namespace Sample.Contracts
{
    public class OrderPlaced : IEvent
    {
        public Guid Id { get; set; }
    }
}