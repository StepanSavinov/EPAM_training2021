using System;

namespace epam_xt
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Josh");

            Order order = new Order(1, Customer.Pizzas);

            customer1.PlaceOrder();

            order.ViewOrder();

            Customer customer2 = new Customer("Chris");

            Order order1 = new Order(2, Customer.Pizzas);

            customer2.PlaceOrder();

            order1.ViewOrder();

            order.Ready();

            order1.Ready();
        }
    }
}
