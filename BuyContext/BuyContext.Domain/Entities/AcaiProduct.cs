using BuyContext.Domain.Enum;

namespace BuyContext.Domain.Entities
{
    public class AcaiProduct : Product
    {

        public AcaiProduct(
            EAcaiSize size,
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
            Size = size;
        }


        public EAcaiSize Size { get; private set; }
    }
}