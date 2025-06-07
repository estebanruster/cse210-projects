public class Product
{
    //Member variables in Product. Each product contains its name, id,
    //price and quantity
    private string _name;
    private int _id;
    private int _price;
    private int _quantity;

    //Construct of Product initialize object with all the prodcut info
    //provided
    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    //GetDisplayProduct method returns string of the product for the
    //GetPackingLabel Order method and TotalProduct calculate the total
    //of the product and returns it for TotalOrder Order method
    public string GetDisplayProduct()
    {
        return $"Product: {_name} | Id:{_id}";
    }
    public int TotalProduct()
    {
        return _price * _quantity;
    }
}