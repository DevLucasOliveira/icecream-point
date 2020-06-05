namespace BuyContext.Domain
{
    public class User : Entity
    {
        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public string UserName { get; private set; }
        public string Password { get; set; }

    }

}