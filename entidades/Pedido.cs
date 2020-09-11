using System;
using System.Collections.Generic;

namespace projeto_poo.entidades
{
    public class Pedido
    {
        public Pedido(string endereco,
                      double preco,
                      //bool status,
                      IList<ItemPedido> itemPedido)
        {
            CodPedido = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);
            Endereco = endereco;
            Preco = preco;
            DataPedido = DateTime.Now;
            //Status = status;
            ItemPedido = itemPedido;
        }
        
        public Pedido(){

        }
        public string CodPedido { get; set; }

        public string Endereco { get; set; }

        public double Preco { get; set; }

        public DateTime DataPedido { get; set; }

        //public Boolean Status { get; set; }

        public IList<ItemPedido> ItemPedido { get; } = new List<ItemPedido>();

        public void CriarPedido(ItemPedido item){
            ItemPedido.Add(item);
        }

        public void CancelarPedido(ItemPedido item){
            ItemPedido.Remove(item);
        }

        public void EncerrarPedido(){

        }

        public void ConsultarPedidos(){
            foreach (var item in ItemPedido)
            {
                Console.WriteLine(item.CodItemPedido);
            }
        }
       
    }
}