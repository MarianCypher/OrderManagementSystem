using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    public abstract class DeliveryFactory
    {
        public static Destination CreateDestination()
        {
            return new Destination();
        }
        public static TransportService CreateTransportService()
        {
            return new TransportService();
        }
    }
}