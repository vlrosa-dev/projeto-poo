using System;

namespace projeto_poo.entidades.home
{
    public class WriteConsole
    {
        public Produto WriteProduct(Produto produto){

            try
            {
                Console.WriteLine("Cadastro do Produto");

                Console.Write("Nome do Produto: ");
                produto.NomeProduto = Console.ReadLine();

                Console.Write("Preço do Produto: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Peso do Produto: ");
                produto.Peso = double.Parse(Console.ReadLine()); 

                Console.Write("Quantidade Disponível: ");
                produto.QtdDisponivel = int.Parse(Console.ReadLine());

                Console.Write("Descrição do Produto: ");
                produto.Descricao = Console.ReadLine();
                
                return produto;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Erro na inserção dos dados! Digite Novamente");
                return WriteProduct(produto);
            }   
  
        }

        public ItemPedido WriteOrder(ItemPedido item){

            Produto prod = new Produto();
            prod.ObterProduto();

            Console.WriteLine($"Nome do Produto: {item.produto.NomeProduto}");

            Console.WriteLine("Informe a quantidade: ");
            item.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Preco do Produto: {item.produto.Preco}");
            item.Preco = item.produto.Preco;

            return item;
            
            
        } 

        public string ConsoleBuscarID(){
            string idProduto;
            
            Console.WriteLine("Informe o ID do Produto: ");
            idProduto = Console.ReadLine();

            return idProduto;
            
        }
    }
}