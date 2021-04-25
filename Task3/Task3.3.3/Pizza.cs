using System;
using System.Collections.Generic;
using System.Text;

namespace epam_xt
{
    class Pizza
    {
        public string Name;
        public int Price;
        public int Quantity;

        public Pizza(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", Name, Price, Quantity);
        }
    }
}
