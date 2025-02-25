using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;

namespace FinanceControl.Infraestructure.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private List<Transaction> Data = new();

        public TransactionRepository() { }

        /// <summary>
        /// Future implementation
        /// </summary>
        /// <param name="transaction">Future implementation</param>
        public async Task AddTransaction(Transaction transaction)
        {
            Data.Add(transaction);
            await Task.CompletedTask;
        }

        /// <summary>
        /// Get all data from the local variable
        /// </summary>
        /// <returns>A list of all the transactions registered in the local variable</returns>
        public async Task<List<TransactionDTO>> GetAllTransactions()
        {
            List<TransactionDTO> data = Data.Select(transaction => new TransactionDTO(transaction.Type, transaction.Value, transaction.Category)).ToList();

            return await Task.FromResult(data);
        }
    }
}
