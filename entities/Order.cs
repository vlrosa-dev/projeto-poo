using System;
using System.Collections.Generic;

namespace projeto_poo.entities
{
    public class Order
    {
        public Order(string customer)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8);
            Date = DateTime.Now;
            Customer = customer;
            this.items = new List<OrderItem>();
        }

        public string Number { get; private set; }

        public DateTime Date { get; set; }

        public string Customer { get; set; }

        public IList<OrderItem> items { get; set; }

        public decimal getTotal(){
            var total = 0m;

            foreach (var item in items)
            {   
                total += item.Price * item.Quantity;
            }

            return total;
        }

    }
}