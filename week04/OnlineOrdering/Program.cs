using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Chrinovic Mbuyu", new Address("116 Kamina Street", "Lubumbashi", "Katanga", "DRC"));
        Customer customer2 = new Customer("Deo Mafo", new Address("2034", "Kilela Balanada", "Lubumbashi", "DRC"));
        
        Product product1 = new Product("Laptop", 101, 1200.00, 1);
        Product product2 = new Product("Mouse", 102, 25.00, 2);
        Product product3 = new Product("Keyboard", 103, 45.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}