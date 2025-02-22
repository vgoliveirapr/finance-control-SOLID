using FinanceControl.Domain.DTOs;

namespace FinanceControl.Application.Services
{
    public interface ITransactionService
    {
        Task AddNewTransaction(TransactionDTO transaction);
    }
}
