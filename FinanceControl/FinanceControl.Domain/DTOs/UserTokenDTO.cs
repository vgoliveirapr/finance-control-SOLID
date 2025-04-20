using FinanceControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Domain.DTOs
{
    public class UserTokenDTO
    {
        public Guid IdUser { get; set; }

        public string Token { get; set; } = string.Empty;
        public DateTime ExpirationDate { get; set; }

        public UserTokenDTO(Guid idUser, string token, DateTime expirationDate)
        {
            IdUser = idUser;
            Token = token;
            ExpirationDate = expirationDate;
        }
    }
}
