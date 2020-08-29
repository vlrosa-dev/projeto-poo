using System;

namespace projeto_poo.entities
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var order = new Order("Victor Rosa");
            var item = new OrderItem("Mouse", 2, 10);
            order.items.Add(item);

            Console.WriteLine(order.getTotal());

        }
    }
}
