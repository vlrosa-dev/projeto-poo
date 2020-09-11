using System;
using System.Collections.Generic;

namespace projeto_poo.entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPedidos = new List<Pedido>();
            int i = 0;
            while (i <= 2)
            {
                
                Pedido pedido = new Pedido();

                Console.Write("Informe o endereco: ");
                pedido.Endereco = Console.ReadLine();

                Console.Write("Informe o preço do produto: ");
                pedido.Preco = double.Parse(Console.ReadLine()); 

                listaPedidos.Add(pedido);

                i+= 1;

            }

            foreach (var item in listaPedidos)
            {
                Console.WriteLine(item.CodPedido);
            }
        
            /*
            var prod01 = new Produto(){
                CodProduto = 12345677,
                NomeProduto = "Mouse",
                Peso = 1.50
            };

            var item01 = new ItemPedido(){
                CodItemPedido = 12345,
                Quantidade = 2,
                Preco = 3.50
            };

            var item02 = new ItemPedido(){
                CodItemPedido = 12345890,
                Quantidade = 2,
                Preco = 3.50
            };

            item01.IncluirItem(prod01);
            pedido01.CriarPedido(item01);
            pedido01.CriarPedido(item02);

            pedido01.ConsultarPedidos();
            Console.WriteLine(pedido01.CodPedido);*/
        
        }
    }
}
