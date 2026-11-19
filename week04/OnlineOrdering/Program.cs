using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA customer ($5 shipping)
        Address address1 = new Address("742 Evergreen Terrace", "Austin", "TX", "USA");
        Customer customer1 = new Customer("Jordan Taylor", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mechanical Keyboard", "PRD-101", 85.00, 1));
        order1.AddProduct(new Product("USB-C Hub", "PRD-204", 29.50, 2));
        order1.AddProduct(new Product("Desk Mat", "PRD-309", 18.00, 1));

        // Order 2: International customer ($35 shipping)
        Address address2 = new Address("14 Baker Street", "London", "Greater London", "United Kingdom");
        Customer customer2 = new Customer("Clara Bennett", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Studio Condenser Microphone", "PRD-412", 120.00, 1));
        order2.AddProduct(new Product("Boom Arm Stand", "PRD-518", 45.00, 2));

        Order[] orders = { order1, order2 };

        for (int i = 0; i < orders.Length; i++)
        {
            Console.WriteLine($"=== Order #{i + 1} ===");
            Console.WriteLine(orders[i].GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(orders[i].GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Price: ${orders[i].CalculateTotalCost():F2}");
            Console.WriteLine(new string('-', 45));
        }
    }
}
