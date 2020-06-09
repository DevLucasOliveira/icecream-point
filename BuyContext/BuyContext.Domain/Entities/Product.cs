using BuyContext.Domain.Enums;

namespace BuyContext.Domain.Entities
{
    public class Product
    {
        public Product(string title, decimal price, EAdditionalItem additionalItem)
        {
            Title = title;
            Price = price;
            EAdditionalItem = additionalItem;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public EAdditionalItem EAdditionalItem { get; private set; }

        /*
        public decimal Price(additional EAdditionalItem)
        {
            return Price + additional;
        }
        */
    }
}