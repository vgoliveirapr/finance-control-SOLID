namespace FinanceControl.Domain.DTOs
{
    public class UserDTO
    {
        public string Name { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string PasswordEncrypted { get; set; } = string.Empty;

        public string Token { get; set; } = string.Empty;

        public DateTime ExpiresIn { get; set; }

        public UserDTO() { }

        public UserDTO(string name, string username, string passwordEncrypted)
        {
            Name = name;
            Username = username;
            PasswordEncrypted = passwordEncrypted;
        }
    }
}
