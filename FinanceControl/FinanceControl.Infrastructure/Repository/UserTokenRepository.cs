using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;
using FinanceControl.Infrastructure.Context;
using FinanceControl.Infrastructure.Interfaces;

namespace FinanceControl.Infrastructure.Repository
{
    public class UserTokenRepository : IUserTokenRepository
    {
        private FinanceControlDbContext database;

        public UserTokenRepository(FinanceControlDbContext databaseContext)
        {
            database = databaseContext;
        }

        public async Task AddUserToken(UserToken user)
        {
            await database.UserTokens.AddAsync(user);
            await database.SaveChangesAsync();
        }

        public async Task<UserTokenDTO> GetUserTokenById(Guid id)
        {
            UserTokenDTO data = database.UserTokens.Where(a => a.IdUser == id)
                .Select(a => new UserTokenDTO(a.IdUser, a.Token, a.ExpirationDate))
                .FirstOrDefault();

            return await Task.FromResult(data);
        }
    }
}
