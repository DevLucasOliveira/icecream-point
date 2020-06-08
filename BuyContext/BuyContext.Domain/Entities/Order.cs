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
            Number = Guid.NewGuid().ToString().Substring(0,0);
            Items = new List<OrderItem>();
        }

        public DateTime Date { get; private set; }
        public string Number { get; private set; }
        public IList<OrderItem> Items { get; private set; }


        

    }

}