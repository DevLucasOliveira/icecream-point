using System;
using System.Collections.Generic;
using Flunt.Validations;

namespace BuyContext.Domain.Entities
{
    public class Order : Entity
    {
        public Order()
        {
            Date = DateTime.Now;
            Number = Guid.NewGuid().ToString().Substring(0, 0);
            Items = new List<OrderItem>();
        }

        public DateTime Date { get; private set; }
        public string Number { get; private set; }
        public IList<OrderItem> Items { get; private set; }


        public void AddItem(Product product, int quantity)
        {
            var item = new OrderItem(product, quantity);
            if (item.Valid)
                Items.Add(item);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Total();
            }

            return total;
        }




    }

}