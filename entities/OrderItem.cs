namespace projeto_poo.entities
{
    public class OrderItem
    {
        public OrderItem(string product, int quantity, decimal price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public string Product { get; set; }
        
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal getTotal(){
            return Price * Quantity;
        }
    }
}