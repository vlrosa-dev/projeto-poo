namespace projeto_poo.entities
{
    public class OrderItem
    {
        public OrderItem(){

        }

        public OrderItem(int quantity, decimal price, Product product) 
        {
            this.Quantity = quantity;
            this.Price = price;
            this.product = product;
               
        }
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public Product product { get; set; }

        public Product GetProduct(string idProduct){
            Product prod = new Product(idProduct);
            return prod;
        }

        public decimal getTotal(){
            return Price * Quantity;
        }
    }
}