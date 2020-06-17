using BuyContext.Domain.Entities;
using BuyContext.Domain.Repositories.Interfaces;

namespace BuyContext.Tests.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        public User Get(string password)
        {
            if (password == "123456")
                return new User("Lucas Oliveira", password);

            return null;
        }
    }
}