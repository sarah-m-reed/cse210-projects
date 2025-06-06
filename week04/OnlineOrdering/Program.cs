using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "NB101", 3.50m, 4));
        order1.AddProduct(new Product("Pen", "P202", 1.25m, 10));

        Address address2 = new Address("45 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Planner", "PL303", 10.00m, 2));
        order2.AddProduct(new Product("Highlighter", "HL404", 0.75m, 8));
        order2.AddProduct(new Product("Eraser", "ER505", 0.50m, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}