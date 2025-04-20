using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;
using FinanceControl.Infrastructure.Context;
using FinanceControl.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private FinanceControlDbContext database;

        public UserRepository(FinanceControlDbContext databaseContext)
        {
            database = databaseContext;
        }

        public async Task CreateUser(User user)
        {
            await database.Users.AddAsync(user);
            await database.SaveChangesAsync();
        }

        public Task<UserDTO> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
