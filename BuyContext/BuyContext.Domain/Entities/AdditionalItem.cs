namespace BuyContext.Domain.Entities
{
    public class AdditionalItem
    {
        public AdditionalItem(string choose)
        {

            switch (choose)
            {
                case "Granola":
                    Price = 3.5M;
                    break;
                case "Granulado":
                    Price = 2.5M;
                    break;
                case "Flocos":
                    Price = 3M;
                    break;
            }
        }

        public decimal Price { get; private set; }

    }
}