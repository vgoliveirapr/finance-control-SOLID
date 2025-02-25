using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;
using FinanceControl.Infraestructure.Repository;

namespace FinanceControl.Application.Services
{
    public class TransactionDebitService : ITransactionService
    {
        private readonly ITransactionRepository repositoryData;

        public TransactionDebitService(ITransactionRepository repository)
        {
            repositoryData = repository;
        }

        /// <summary>
        /// Add the financial transaction to database
        /// </summary>
        /// <param name="transaction">Financial transaction with the value, category and type</param>
        /// <returns>Future implementation</returns>
        public async Task AddNewTransaction(TransactionDTO transaction)
        {
            Transaction financialTransaction = new(transaction.Type, -transaction.Value, transaction.Category);
            await repositoryData.AddTransaction(financialTransaction);
        }
    }
}
