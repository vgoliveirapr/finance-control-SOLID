using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;

namespace FinanceControl.Infrastructure.Interfaces
{
    public interface ITransactionRepository
    {
        Task AddTransaction(Transaction transaction);
        Task<List<TransactionDTO>> GetAllTransactions();
    }
}
