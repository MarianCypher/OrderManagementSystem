using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    internal interface IOrderBuilder
    {
        public object StartBuildingOrder();
        public int SetOrderID();
        public List<Product> SetBasket();
        public Delivery SetDelivery(Destination Destination, TransportService TransportService);
    }
}
