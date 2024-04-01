using System;
using System.Security.Cryptography.X509Certificates;

namespace OrderManagementSystem;

/* Stwórz klasę OrderManager, która będzie odpowiedzialna za zarządzanie zamówieniami.
 * Upewnij się, że OrderManager jest singletonem, aby istniał tylko jeden egzemplarz tej klasy w całym systemie.
 */
public class OrderManager
{
    private string ManagerName;
    private static OrderManager? instance;
    private OrderManager(string managerName)
    {
        ManagerName = managerName;
    }
    public static OrderManager GetInstance(string Name)
    {
        if (instance == null)
        {
            instance = new OrderManager(Name);
        }
        return instance;
    }
    public string SellYell()
    {
        return "We have a sale!";
    }
    public string Introduce()
    {
        return "'I'm " + ManagerName + "!'";
    }
}
