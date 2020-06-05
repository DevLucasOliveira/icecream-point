using System;
using Flunt.Notifications;

namespace BuyContext.Domain
{
    public class Entity: Notifiable
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}