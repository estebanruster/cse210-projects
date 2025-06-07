public class Customer
{
    //Customer member variables contains name of customer and address as
    //an Address object
    private string _name;
    private Address _address;

    //Constructor initialize object with the string provided for name and
    //the Address privided for address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //GetDisplayCustomer is used for the GetShippingLabel and takes the
    //address info from GetDisplayAddress in the Address class; and the
    //LivesInTheUSA method takes the bool return from CountryUSA and
    //return bool to calculate TotalOrder due to shipping fee diferences
    public string GetDisplayCustomer()
    {
        return $"{_name}\n{_address.GetDisplayAddress()}";
    }
    public bool LivesInTheUSA()
    {
        return _address.CountryUSA();
    }
}