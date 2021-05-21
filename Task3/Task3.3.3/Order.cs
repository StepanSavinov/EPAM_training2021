using System;
using System.Collections.Generic;
using System.Text;

namespace epam_xt
{
    class Order
    {
        public event Action<Order> OnReady = delegate { };

        public int Number;

        public List<Pizza> Pizzas { get; }

        public Order(int number, List<Pizza> pizzas)
        {
            Number = number;
            Pizzas = Customer.Pizzas;
        }

        public void ViewOrder()
        {
            int TotalCost = 0;

            foreach (var item in Pizzas)
            {
                Console.WriteLine("Pizza: {0}, Cost: {1}, Quantity: {2}", item.Name, item.Price, item.Quantity);
                TotalCost += item.Price * item.Quantity;
            }

            Console.WriteLine("Total cost: {0}", TotalCost);
            Customer.Pizzas.Clear();
        }

        public void Ready()
        {
            Console.WriteLine("Order {0} is ready!", Number);
            OnReady?.Invoke(this);
            
        }
    }
}
