using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;
using FinanceControl.Infrastructure.Repository;

namespace FinanceControl.Application.Services
{
    public class DataRepositoryService
    {
        private readonly ITransactionRepository repositoryData;

        public DataRepositoryService(ITransactionRepository repository)
        {
            repositoryData = repository;
        }

        public async Task<List<TransactionDTO>> GetAllTransactions()
        {
            return await repositoryData.GetAllTransactions();
        }
    }
}
