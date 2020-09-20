using System;
using System.Collections;
using System.Collections.Generic;

namespace projeto_poo.entidades.home
{
    public class InterfaceConsole
    {
        public void CreateProduct(){

            ReadConsole read = new ReadConsole();
            Produto produto = new Produto(); 

            int chooseOption;
            chooseOption = read.MenuProduto();

            while (chooseOption != 0)
            {
                switch (chooseOption)
                {
                    case 1:      
                        produto.CadastrarProduto(new Produto());
                        break;
                    
                    case 2:
                        produto.BuscarProdutos();
                        break;

                    case 3:
                        produto.ObterProduto();
                        break;

                    case 4:
                        produto.RemoverProduto();
                        break;
                        
                    default:
                        Console.WriteLine("Opção Invalida!!");
                        break;
                }

                chooseOption = read.MenuProduto();
            }

        }

        public void CreateOrder(){

            ReadConsole read = new ReadConsole();
            Pedido pedido = new Pedido();
            ItemPedido item = new ItemPedido();

            int chooseOption;
            chooseOption = read.MenuOrder();

            while (chooseOption != 0)
            {
            switch (chooseOption)
                {
                    case 1:      
                        new Pedido().AdicionarItemPedido(new ItemPedido(item.produto.ObterProduto()));
                        break;
                    
                    case 2:
                        pedido.VisualizarItensPedidos();
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        
                        break;
                        
                    default:
                        Console.WriteLine("Opção Invalida!!");
                        break;
                }

                chooseOption = read.MenuOrder();
            }
        }
 

    }
}