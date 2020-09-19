using System;

namespace projeto_poo.entidades
{
    public class ItemPedido
    {
        public ItemPedido(){

        }

        public string CodItemPedido { get; } = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8);

        public int Quantidade { get; set; }

        public decimal Preco { get; set; }

        public Produto produto { get; set; }

        public decimal GetTotal(){
            return Quantidade * Preco;
        }

    }
}