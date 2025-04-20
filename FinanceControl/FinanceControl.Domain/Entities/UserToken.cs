namespace FinanceControl.Domain.Entities
{
    public class UserToken
    {
        public Guid IdUserToken { get; set; }

        public Guid IdUser { get; set; }

        public string Token { get; set; } = string.Empty;

        public DateTime CreationDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public User User { get; set; }

        public UserToken(Guid idUser, string token, DateTime creationDate, DateTime expirationDate)
        {
            IdUserToken = Guid.NewGuid();
            IdUser = idUser;
            Token = token;
            CreationDate = creationDate;
            ExpirationDate = expirationDate;
        }
    }
}
