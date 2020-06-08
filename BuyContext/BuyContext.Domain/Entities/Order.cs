using System;
using System.Collections.Generic;

namespace BuyContext.Domain.Entities
{
    public class Order : Entity
    {
        public Order( DateTime date)
        {
            Date = date;
            Number = Guid.NewGuid().ToString().Substring(0,0);
        }

        public DateTime Date { get; private set; }
        public string Number { get; private set; }
        public IList<OrderItem> Items { get; private set; }


        

    }

}