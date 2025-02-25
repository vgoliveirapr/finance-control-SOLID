using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;

namespace FinanceControl.Infraestructure.Repository
{
    public interface ITransactionRepository
    {
        Task AddTransaction(Transaction transaction);
        Task<List<TransactionDTO>> GetAllTransactions();
    }
}
