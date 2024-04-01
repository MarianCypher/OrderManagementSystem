namespace OrderManagementSystem
{
    internal class Delivery
    {
        public Destination Destination { get; }

        public TransportService TransportService { get; }

        public Delivery(Destination destination, TransportService transportService)
        {
            Destination = destination;
            TransportService = transportService;
        }
    }
}