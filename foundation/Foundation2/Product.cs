public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Getter for product name
    public string GetName()
    {
        return _name;
    }

    // Getter for product ID
    public string GetProductId()
    {
        return _productId;
    }

    // Method to calculate the total cost of the product
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}
