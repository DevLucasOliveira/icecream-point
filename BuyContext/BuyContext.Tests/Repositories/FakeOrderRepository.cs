using BuyContext.Domain.Entities;
using BuyContext.Domain.Repositories.Interfaces;

namespace BuyContext.Tests.Repositories
{
    public class FakeOrderRepository : IOrderRepository
    {
        public void Save(Order order) { }
    }
}