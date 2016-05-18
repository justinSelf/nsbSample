using NServiceBus;

namespace ProcessHandler
{
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence>();
            configuration.EndpointName("ProcessHandler");
        }
    }
}
