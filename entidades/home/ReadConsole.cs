using System;

namespace projeto_poo.entidades
{
    public class ReadConsole
    {
        public int MenuProduto(){
            try
            {
                int escolha;

                Console.WriteLine("Console de Produtos: ");
                Console.Write("| 1 - Cadastrar Produto");
                Console.Write("| 2 - Visualizar Produto");
                Console.Write("| 3 - Buscar Produto");
                Console.Write("| 4 - Remover Produto");
                Console.WriteLine("| 0 - Voltar ");
                Console.Write("Resposta: ");   
                escolha = int.Parse(Console.ReadLine());
            
                return escolha;
            }
            catch (SystemException)
            {
                Console.WriteLine("Opção invalida! Digite Novamente");
                return MenuProduto();
            }
        }

        public int MenuHome(){
            int escolha;
            try
            {
                Console.WriteLine("Menu Principal: ");
                Console.Write("| 1 - Produtos");
                Console.Write("| 2 - Pedidos");
                Console.Write("| 3 - Estoque");
                Console.WriteLine("| 0 - Sair");
                Console.Write("Resposta: ");
                escolha = int.Parse(Console.ReadLine());

                return escolha;       
            }
            catch (System.Exception) 
            {
                Console.WriteLine("Opção invalida! Digite Novamente");
                return MenuHome();
            } 
       
        }

        public int MenuOrder(){
            int escolha;
            try
            {
                Console.WriteLine("Console de Pedido: ");
                Console.Write("| 1 - Novo Pedido");
                Console.WriteLine("| 0 - Sair");
                Console.Write("Resposta: ");
                escolha = int.Parse(Console.ReadLine());

                return escolha; 
            }
            catch (System.Exception)
            {
                Console.WriteLine("Opção Invalida! Digite Novamente");
                return MenuOrder();
            }
        }
    }
}