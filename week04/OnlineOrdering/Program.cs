/*
Author: Esteban Rubén Mangas Calva
W04 Assignment: Online Ordering Program
Encapsulation principle
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        //Initialize 1st order, its products, customer and address (in
        //the USA)
        Address address1 = new Address("Valley Bulevard 305", "Santa Mónica", "Guadalajara", "México");
        Customer customer1 = new Customer("Esteban Mangas", address1);
        Order order1 = new Order(customer1);
        Product product01 = new Product("Switch 2", 202537, 399, 1);
        order1.AddProduct(product01);
        Product product02 = new Product("Mario Kart World", 202509, 79, 1);
        order1.AddProduct(product02);
        Product product03 = new Product("Piranha Plant Camara", 202591, 59, 1);
        order1.AddProduct(product03);

        //Initialize 2nd order, its products, customer and address (in
        //the USA)
        Address address2 = new Address("North Street 144", "Terrance", "Missuri", "USA");
        Customer customer2 = new Customer("Sara Calderón", address2);
        Order order2 = new Order(customer2);
        Product product11 = new Product("Camara", 000091, 99, 2);
        order2.AddProduct(product11);
        Product product12 = new Product("Micro SD memory card", 202048, 19, 5);
        order2.AddProduct(product12);

        //Displaying labels and price of the orders
        Console.WriteLine($"Packing Label\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label\n{order1.GetShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total + ship fee: ${order1.TotalOrder()}");
        Console.WriteLine();
        Console.WriteLine($"Packing Label\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label\n{order2.GetShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total + ship fee: ${order2.TotalOrder()}");
    }
}