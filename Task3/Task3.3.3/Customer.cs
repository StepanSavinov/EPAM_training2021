using System;
using System.Collections.Generic;
using System.Text;

namespace epam_xt
{
    class Customer
    {
        string Name;
        
        public Customer(string name)
        {
            Name = name;
        }

        public static List<Pizza> Pizzas = new List<Pizza>();
        public void PlaceOrder()
        {
            int temp = 0;
            string input = "";

            do
            {
                Console.WriteLine("Hello, {0}! How many different pizzas will be in your order?", Name);
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out temp));

            string pizzaName;
            string pizzaPrice;
            string pizzaQuantity;

            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine("What kind of pizza do you want?");
                pizzaName = Console.ReadLine();

                int price = 0;
                do
                {
                    Console.WriteLine("Enter the price of pizza: ");
                    pizzaPrice = Console.ReadLine();
                } while (!Int32.TryParse(pizzaPrice, out price));

                
                
                int quantity = 0;
                do
                {
                    Console.WriteLine("Enter the quantity of pizza: ");
                    pizzaQuantity = Console.ReadLine();
                } while (!Int32.TryParse(pizzaQuantity, out quantity));


                Pizzas.Add(new Pizza(pizzaName, price, quantity));
            }
        }
    }
}
