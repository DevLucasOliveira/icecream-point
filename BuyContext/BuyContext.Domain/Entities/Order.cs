using System;

namespace BuyContext.Domain.Entities
{
    public class Order : Entity
    {
        public Order( User user, DateTime date)
        {
            User = user;
            Date = date;
        }

        public User User { get; private set; }
        public DateTime Date { get; private set; }
        //Adicionar uma lista de itens de pedido
    }

}