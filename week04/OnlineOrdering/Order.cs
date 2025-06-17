using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine("Packing Label:");
        foreach (Product product in _products)
        {
            Console.WriteLine($"- {product.GetPackingLabel()}");
        }

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(_customer.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${GetTotalPrice()}");
    }
}
