using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating new Order
        Order order1 = new Order(new Customer("Ethan Carter", new Address("55 Sunset Boulevard", "Los Angeles", "California", "USA")));
        Order order2 = new Order(new Customer("Mario Rossi", new Address("Via del Corso 12", "Rome", "Lazio", "Italy")));
        // Adding some Products to the Orders
        order1.AddProduct(new Product("Apple", "001", 1.50, 2));
        order1.AddProduct(new Product("Banana", "002", 1, 3));
        order1.AddProduct(new Product("Pineapple", "003", 4, 2));
        order2.AddProduct(new Product("Apple", "001", 1.5, 7));
        order2.AddProduct(new Product("Avocado", "004", 0.75, 5));
        order2.AddProduct(new Product("Water Melon", "005", 12, 1));
        order2.AddProduct(new Product("Peach", "006", 0.5, 8));
        order2.AddProduct(new Product("Banana", "002", 1, 5));
        // Calling some method for the Order number 1
        Console.WriteLine($"The toatl cost is: {order1.CalculateTotalCost()}");
        Console.WriteLine($"The packing label is: {order1.GetPackingLabel()}");
        Console.WriteLine($"The shipping label is: {order1.GetShippingLabel()}");
        Console.WriteLine();
        // Calling some method for the Order number 2
        Console.WriteLine($"The toatl cost is: {order2.CalculateTotalCost()}");
        Console.WriteLine($"The packing label is: {order2.GetPackingLabel()}");
        Console.WriteLine($"The shipping label is: {order2.GetShippingLabel()}");

    }
}