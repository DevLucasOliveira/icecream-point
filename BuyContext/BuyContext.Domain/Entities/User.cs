
using Flunt.Validations;

namespace BuyContext.Domain.Entities
{
    public class User : Entity
    {
        public User(string userName, string password)
        {
            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNullOrEmpty(userName, "UserName", "O usuário não pode ser vazio")
                .IsNotNullOrEmpty(password, "Password", "A senha não pode ser vazia")
            );

            UserName = userName;
            Password = password;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }

    }

}