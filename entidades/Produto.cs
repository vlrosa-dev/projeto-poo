using System;
using System.Linq;
using System.Collections.Generic;
using projeto_poo.entidades.home;

    public class Produto
    {
        public Produto(){

        }

        public string CodProduto { get; } = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8);

        public string NomeProduto { get; set; }

        public decimal Preco { get; set; }

        public double Peso { get; set; }

        public int QtdDisponivel { get; set; }

        public string Descricao { get; set; }

        public HashSet<Produto> listProducts { get; set; } = new HashSet<Produto>();

        public override bool Equals(object obj)
        {
            if(obj is Produto){
                Produto p = new Produto();
                return this.CodProduto.Equals(p.CodProduto);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.CodProduto == null ? 0 : this.CodProduto.GetHashCode());
        }

        public void CadastrarProduto(Produto p){
            
            WriteConsole write = new WriteConsole();
            listProducts.Add(write.WriteProduct(p));

            Console.WriteLine($"O produto {p.NomeProduto} ({p.CodProduto}) foi adicionado com sucesso.");
        }

        public void BuscarProdutos(){
            foreach (Produto produto in listProducts)
            {
                Console.WriteLine($"Cod. do Produto: {produto.CodProduto} | Nome do Produto: {produto.NomeProduto}");
            }
        }

        public Produto ObterProduto(){
            WriteConsole write = new WriteConsole();
        
            Produto ObterProduto = listProducts.FirstOrDefault(delegate(Produto produto){
                return produto.CodProduto == write.ConsoleBuscarID();
            });

            Console.WriteLine($"Produto localizado com ID = {ObterProduto.CodProduto}");
            Console.WriteLine($"Nome do Produto Obtido = {ObterProduto.NomeProduto}");
            
            return ObterProduto;
        }

        public void RemoverProduto(){
            
            WriteConsole write = new WriteConsole();

            Produto RemoverProduto = listProducts.FirstOrDefault(delegate(Produto produto){
                return produto.CodProduto == write.ConsoleBuscarID();
            });

            listProducts.Remove(RemoverProduto);

            Console.WriteLine($"O produto {RemoverProduto.NomeProduto} ({RemoverProduto.CodProduto}) foi removido com sucesso");

        }

    }
