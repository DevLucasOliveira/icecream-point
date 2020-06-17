using BuyContext.Domain.Entities;

namespace BuyContext.Domain.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void Save(Order order);
    
    }
}