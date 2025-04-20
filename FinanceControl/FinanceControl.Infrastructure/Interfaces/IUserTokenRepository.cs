using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Infrastructure.Interfaces
{
    public interface IUserTokenRepository
    {
        Task AddUserToken(UserToken user);

        Task<UserTokenDTO> GetUserTokenById(Guid id);
    }
}
