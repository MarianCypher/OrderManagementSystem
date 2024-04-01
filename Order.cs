using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace OrderManagementSystem;

public class Order : ICloneable
{
    public int OrderId { get; }
    public List<Product> Basket { get; }
    public string Delivery { get; }
    public Order(int orderId, List<Product> basket, string deliveryAddress)
    {
        OrderId = orderId;
        Basket = basket;
        Delivery = deliveryAddress;
    }
    public object Clone() //shallow copy
    {
        return (Order) this.MemberwiseClone();
    }
    public object DeepCopy() //deep copy
    {
        return new Order(OrderId, Basket, Delivery);  //wiem, ze to nie deep copy, ale gdyby byla jakas logika obiektu za ktoryms z parametrow to bym tutaj ja sparametryzowal
    }
}
