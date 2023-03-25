using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        // Make sure that all member variables are private and getters, setters, and constructors are created as needed.

        // Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.

        Product product1 = new Product("Book", "8937", 10.99, 2);
        Product product2 = new Product("Back pack", "2464", 20.65, 5);
        Product product3 = new Product("Unicycle", "4629", 140.34, 1);

        Order order1 = new Order();
        Address address1 = new Address("238 Leaf Trl.", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Emma Johnson", address1);
        order1.AddItem(product1);
        order1.AddItem(product3);
        // order1.PrintAllCosts(address1);
        order1.PrintTotalCost(address1);
        order1.PrintPackingLabel();
        order1.PrintShippingLabel(address1, customer1);
        Console.WriteLine();

        Order order2 = new Order();
        Address address2 = new Address("324 Water Ave.", "Amsterdam", "North Holland", "Netherlands");
        Customer customer2 = new Customer("Levi Jones", address2);
        order2.AddItem(product2);
        order2.AddItem(product3);
        // order2.PrintAllCosts(address2);
        order2.PrintTotalCost(address2);
        order2.PrintPackingLabel();
        order2.PrintShippingLabel(address2, customer2);

    }
}