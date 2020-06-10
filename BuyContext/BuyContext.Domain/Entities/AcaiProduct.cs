using BuyContext.Domain.Enums;

namespace BuyContext.Domain.Entities
{
    public class AcaiProduct : Product
    {

        public AcaiProduct(
            EAcaiSize size,
            string title,
            decimal price,
            AdditionalItem additionalItem
        ) : base(
            title,
            price,
            additionalItem
        )
        {
            Size = size;
        }


        public EAcaiSize Size { get; private set; }
    }
}