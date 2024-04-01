using System.Security.Cryptography.X509Certificates;

/* Celem tego ćwiczenia jest zastosowanie wszystkich kreacyjnych wzroców projektowych.
 * Factory Method [X]
 * Abstract Factory [X]
 * Builder [ ]
 * Singleton [X]
 * Prototype [X]
 */

namespace OrderManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test 1: Product class : build the instance and print its properties
            var ksiazka = new Product("Ksiazka kucharska", 29.95, 1);
            Console.WriteLine("TEST 1 // Wybrano pozycje " + ksiazka.Name + " w cenie " + ksiazka.Value + " w ilosci " + ksiazka.Quantity);
            Console.WriteLine();  //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<CZY JEST BARDZIEJ ELEGANCKIE ROZWIAZANIE?

            // Test 2: Order class : build the instance and print its properties
            var ebook = new Product("Ebook historyczny", 45.25, 3);
            List<Product> koszyk = new List<Product> { ksiazka, ebook};
            var zamowienie = new Order(321123, koszyk, "Ulica 1/1");
            Console.WriteLine("TEST 2 // Nowe zamowienie o numerze: " + zamowienie.OrderId + " i zawartości " + zamowienie.Basket[0] + " zostanie dostaczone pod adres " + zamowienie.Delivery);
            Console.WriteLine();

            // Test 3: OrderManager : yelling with its method
            Console.WriteLine("TEST 3 // OrderManager method accesing ");
            var kiero = OrderManager.GetInstance("Bob");
            Console.WriteLine(kiero.Introduce());
            Console.WriteLine(kiero.SellYell());
            Console.WriteLine();

            // Test 4: OrderManager : Singleton try
            var drugiKiero = OrderManager.GetInstance("Dick");
            if (kiero.Introduce() == drugiKiero.Introduce())
            {
                Console.WriteLine("Test 4 // OK! Singleton is single");
                Console.WriteLine("Hurra! Pierwszy kiero to "+ kiero.Introduce() + " a drugi kiero to tez " + drugiKiero.Introduce());
            }
            else
            {
                Console.WriteLine("Test 4 // FAIL!");
            }
            Console.WriteLine();

            // Test 5: Prototype test, shallow copy
            Order? zamowienie2 = zamowienie.Clone() as Order;
            Console.WriteLine("TEST 5 // Sklonowane zamowienie to: " + zamowienie2.OrderId + " i zawartości " + zamowienie2.Basket[0] + " zostanie dostaczone pod adres " + zamowienie2.Delivery);
            Console.WriteLine();

            // Test 6: Prototype test, deep copy
            Order? zamowienie3 = zamowienie.DeepCopy() as Order;
            Console.WriteLine("TEST 6 // DOGŁĘBNIE Sklonowane zamowienie to: " + zamowienie3.OrderId + " i zawartości " + zamowienie3.Basket[0] + " zostanie dostaczone pod adres " + zamowienie3.Delivery);
            Console.WriteLine();

            // Test 7: Creating Delivery object
            Delivery dostawaPaczki = new Delivery(DeliveryPackage.CreateDestination(),DeliveryPackage.CreateTransportService());
        }   
    }
}