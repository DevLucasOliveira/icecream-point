namespace BuyContext.Domain.Entities
{
    public class OrderItem : Entity
    {

        public OrderItem(Product product, int quantity)
        {
            Product = product; 
            Quantity = quantity;
        }


        public Product Product { get; private set; }
        public int Quantity { get; private set; }


    }
}