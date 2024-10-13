using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some product objects
        Product product1 = new Product("Laptop", "P001", 1200, 1);
        Product product2 = new Product("Mouse", "P002", 25, 2);
        Product product3 = new Product("Keyboard", "P003", 50, 1);
        
        Product product4 = new Product("Phone", "P004", 800, 1);
        Product product5 = new Product("Charger", "P005", 20, 2);

        // Create some customer objects
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create order for the first customer
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create order for the second customer
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display packing label, shipping label, and total cost for each order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
