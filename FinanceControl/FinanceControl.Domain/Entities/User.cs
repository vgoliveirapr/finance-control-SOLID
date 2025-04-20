namespace FinanceControl.Domain.Entities
{
    public class User
    {
        public Guid IdUser { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string PasswordEncrypted { get; set; } = string.Empty;

        public char IsActive { get; set; }

        public DateTime RegistrationDate { get; set; }

        public ICollection<UserToken> UserTokens { get; set; }

        public User(string name, string username, string passwordEncrypted)
        {
            DateTime now = DateTime.Now;
            IdUser = Guid.NewGuid();
            Name = name;
            Username = username;
            PasswordEncrypted = passwordEncrypted;
            IsActive = 'Y';
            RegistrationDate = now.AddMilliseconds(-now.Millisecond);
        }
    }
}
