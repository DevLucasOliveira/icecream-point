namespace BuyContext.Domain.Entities
{
    public class Product
    {
        public Product(string title, decimal price, bool roof, bool additionalItem)
        {
            Title = title;
            Price = price;
            Roof = roof;
            AdditionalItem = additionalItem;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public bool Roof { get; private set; }
        public bool AdditionalItem { get; private set; }
        //Trocar tipo boolean para enum e com isso definir os valores de acrescimo
        //Verificar como fazer um array para ir somando os preços


    }
}