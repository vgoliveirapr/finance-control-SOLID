using FinanceControl.Domain.DTOs;

namespace FinanceControl.Application.Interfaces
{
    public interface ITransactionService
    {
        Task AddNewTransaction(TransactionDTO transaction);
    }
}
