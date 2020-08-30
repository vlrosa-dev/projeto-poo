using System;

namespace projeto_poo.entities
{
    public class Product
    {
        public Product(string idProduct){
            this.idProduct = idProduct;
        }
        
        public Product(string idProduct,
                       string nameProduct,
                       decimal priceCost,
                       decimal priceBuy,
                       int quantityStock)
        {
            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.priceCost = priceCost;
            this.priceBuy = priceBuy;
            this.quantityStock = quantityStock;
        }

        public String idProduct { get; set; }

        public string nameProduct { get; set; }

        public decimal priceCost { get; set; }

        public decimal priceBuy { get; set; }

        public int quantityStock { get; set; }

    }
}