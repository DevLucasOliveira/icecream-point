using BuyContext.Domain.Entities;

namespace BuyContext.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User Get(string user);
    }
}