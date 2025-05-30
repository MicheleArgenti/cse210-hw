public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public double CalculateTotalCost()
    {
        double result = 0;
        foreach (Product product in _products)
        {
            result += product.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            result += 5;
        }
        else
        {
            result += 35;
        }
        return result;
    }

    public string GetPackingLabel()
    {
        return "124 Maplewood Drive\nPortland Oregon\nUSA";
    }

    public string GetShippingLabel()
    {
        return _customer.GetAddress();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}