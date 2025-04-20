using FinanceControl.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(UserDTO user);
    }
}
