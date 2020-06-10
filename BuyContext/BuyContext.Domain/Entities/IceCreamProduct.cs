using BuyContext.Domain.Enums;

namespace BuyContext.Domain.Entities
{
    public class IceCreamProduct : Product
    {
        public IceCreamProduct(
            int numberOfBals,
            string title,
            decimal price,
            AdditionalItem additionalItem
        ) : base(
            title,
            price,
            additionalItem
        )
        {
            NumberOfBalls = numberOfBals;
        }
        public int NumberOfBalls { get; private set; }
    }
}