namespace BuyContext.Domain.Entities
{
    public class IceCreamProduct : Product
    {
        public IceCreamProduct(
            int numberOfBals,
            string title,
            decimal price,
            bool roof,
            bool additionalItem
        ) : base(
            title,
            price,
            roof,
            additionalItem
        )
        {
            NumberOfBalls = numberOfBals;
        }
        public int NumberOfBalls { get; private set; }
    }
}