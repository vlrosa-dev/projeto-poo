using System;
using System.Collections.Generic;

namespace projeto_poo.entidades
{
    public class ItemPedido
    {
        public int CodItemPedido { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public IList<Produto> Produto { get; } = new List<Produto>();

        public void IncluirItem(Produto p){
            Produto.Add(p);
        }

        public void ExcluirItem(Produto p){
            Produto.Remove(p);
        }

    }
}