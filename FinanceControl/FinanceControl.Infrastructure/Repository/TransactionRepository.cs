using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;
using FinanceControl.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly FinanceControlDbContext database;

        public TransactionRepository(FinanceControlDbContext databaseContext) 
        {
            database = databaseContext;
        }

        /// <summary>
        /// Future implementation
        /// </summary>
        /// <param name="transaction">Future implementation</param>
        public async Task AddTransaction(Transaction transaction)
        {
            await database.Transactions.AddAsync(transaction);
            await database.SaveChangesAsync();
        }

        /// <summary>
        /// Get all data from the local variable
        /// </summary>
        /// <returns>A list of all the transactions registered in the local variable</returns>
        public async Task<List<TransactionDTO>> GetAllTransactions()
        {
            List<TransactionDTO> data = await database.Transactions.Select(transaction => new TransactionDTO(transaction.Type, transaction.Value, transaction.Category)).ToListAsync();

            return await Task.FromResult(data);
        }
    }
}
