using FinanceControl.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Application.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(UserDTO user);

        Task Login(UserDTO user);
    }
}
