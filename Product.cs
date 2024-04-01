using System;

namespace OrderManagementSystem;

public class Product
{
    public string Name { get; }
    public double Value { get; }
    public int Quantity { get; }
    public Product (string name, double value, int quantity)
    {
        Name = name;
        Value = value;
        Quantity = quantity;
    }
}
