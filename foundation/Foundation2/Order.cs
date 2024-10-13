using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total cost of the order
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        // Add shipping cost based on customer location
        if (_customer.IsInUSA())
        {
            totalCost += 5;  // Shipping cost for USA
        }
        else
        {
            totalCost += 35; // Shipping cost for outside USA
        }

        return totalCost;
    }

    // Method to generate the packing label (list of products)
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to generate the shipping label (customer name and address)
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
