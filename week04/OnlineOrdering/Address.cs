public class Address
{
    //Member variables contains in string each part of the address info
    //(street address, city, state/province and country)
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    //Constructor initialize the object with the info provided for each
    //of its variables
    public Address(string streetAddres, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddres;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    //CountryUSA method checks if the country is USA and return a bool
    //for LivesInTheUSA Customer method; and GetDisplayAddress return the
    //string for the GetDisplayCustomer Customer method
    public bool CountryUSA()
    {
        return true;
    }
    public string GetDisplayAddress()
    {
        return "";
    }
}