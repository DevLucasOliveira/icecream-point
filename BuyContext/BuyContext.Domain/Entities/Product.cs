using BuyContext.Domain.Entities;
using Flunt.Validations;

namespace BuyContext.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string title, decimal price, AdditionalItem additionalItem)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNull(title, "Title", "O produto deve conter um nome")
                .IsGreaterThan(price, 0 ,"Price", "O valor do produto deve ser maior que zero")
            );

            if (additionalItem != null)
                price += additionalItem.Price;

            Title = title;
            Price = price;
            AdditionalItem = additionalItem;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public AdditionalItem AdditionalItem { get; private set; }


    }

}