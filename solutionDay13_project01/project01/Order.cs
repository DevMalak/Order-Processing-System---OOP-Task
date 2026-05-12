using System;
using System.Collections.Generic;

using System.Collections.Generic;

namespace project01
{
    public class Order
    {
        public List<Product> Products = new List<Product>();

        public string Status { get; set; }

        public double GetTotal()
        {
            double total = 0;

            foreach (var p in Products)
            {
                total += p.Price * p.Quantity;
            }

            return total;
        }
    }
}