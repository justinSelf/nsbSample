using NServiceBus;

namespace ShipOrderHandler
{
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence>();
            configuration.EndpointName("ShipOrderHandler");
        }
    }
}
