using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    internal class OrderBuilder : IOrderBuilder
    {
        private OrderBuilder() { }
        public object StartBuildingOrder()
        {
            return new OrderBuilder();
        }
        public int SetOrderID()
        {
            return 111111;
        }
        public List<Product> SetBasket()
        {
            var typowaKsiazka = new Product("Ksiazka", 39.99, 1);
            var typowyEBook = new Product("EBook", 45.00, 1);
            List<Product> koszyk = new List<Product> { typowaKsiazka, typowyEBook };
            return koszyk;
        }
        public Delivery SetDelivery(Destination Destination, TransportService TransportService)
        {
            return new Delivery(Destination, TransportService);
        }
    }
}
