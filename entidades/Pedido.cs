using System;
using projeto_poo.entidades.home;
using System.Collections.Generic;

namespace projeto_poo.entidades
{
    public class Pedido
    {

        public string CodPedido { get; set; } = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8);

        public DateTime DataPedido { get ; set; } = DateTime.Now;

        public IList<ItemPedido> ListItensPedidos { get; set; }

        public decimal PrecoTotal
        {
            get
            {
                var total = 0m;
                for (int i = 0; i < ListItensPedidos.Count; i++)
                {
                    ItemPedido item = ListItensPedidos[i];
                    total += item.GetTotal();
                }

                return total;
            }
        }

        public void AdicionarItemPedido(ItemPedido item){

            WriteConsole write = new WriteConsole();
            ListItensPedidos.Add(write.WriteOrder(item));

        }

       
    }
}