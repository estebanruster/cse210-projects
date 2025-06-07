public class Order
{
    //Member variables of the Order. An order contains a list of products
    //and customer info
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    //Order constructor and AddProduct method to initialize an Order with
    //a Customer object with customer info and to add Product objects to
    //the list
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }

    //Methods to calculate the TotalOrder with TotalProduct method from
    //Product and the get labels methods that use the get display methods
    //in Product and Customer
    public int TotalOrder()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total = total + product.TotalProduct();
        }
        if (_customer.LivesInTheUSA() == true)
        {
            total = total + 5;
        }
        else
        {
            total = total + 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel = packingLabel + $"{product.GetDisplayProduct()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return _customer.GetDisplayCustomer();
    }
}