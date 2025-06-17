using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("123 Main St", "São Paulo", "SP", "Brazil");
        Customer customer1 = new Customer("Filipe Batista", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Headphones", "P001", 100, 2));
        order1.AddProduct(new Product("Mouse", "P002", 50, 1));

        // Order 2
        Address address2 = new Address("456 Elm St", "New York", "NY", "USA");
        Customer customer2 = new Customer("Ana Souza", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P003", 75, 1));
        order2.AddProduct(new Product("Monitor", "P004", 200, 2));

        order1.DisplayOrderDetails();
        Console.WriteLine();
        order2.DisplayOrderDetails();
    }
}
