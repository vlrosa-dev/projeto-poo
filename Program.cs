using System;

namespace projeto_poo.entities
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var order = new Order("Victor Rosa");
            var item = new OrderItem();
            //var prod = new Product("123456");

            //Console.Write("Informe o nome do produto: ");
            //prod.nameProduct = Console.ReadLine();

            Console.Write("Informe a quantidade do produto: ");
            item.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Informe o preço do produto: ");
            item.Price = decimal.Parse(Console.ReadLine());
 
            order.items.Add(item);

            foreach (var i in order.items)
            {
                Console.WriteLine("Produto: "+ i.product.nameProduct + " | Quantidade: " + i.Quantity + " | Preco: " + i.Price);
            }
   

        }
    }
}
