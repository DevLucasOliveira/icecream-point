using BuyContext.Domain.Entities;

namespace BuyContext.Domain.Entities
{
    public class Product
    {
        public Product(string title, decimal price, AdditionalItem additionalItem)
        {
            if (additionalItem != null)
                Price += additionalItem.Flocos;

            Title = title;
            Price = price;
            AdditionalItem = additionalItem;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public AdditionalItem AdditionalItem { get; private set; }

    }
}