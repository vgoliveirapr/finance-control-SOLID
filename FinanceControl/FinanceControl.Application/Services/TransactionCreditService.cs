using FinanceControl.Application.Interfaces;
using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;
using FinanceControl.Infrastructure.Interfaces;

namespace FinanceControl.Application.Services
{
    public class TransactionCreditService : ITransactionService
    {
        private readonly ITransactionRepository repositoryData;

        public TransactionCreditService(ITransactionRepository repository)
        {
            repositoryData = repository;
        }

        /// <summary>
        /// Add the financial transaction to database
        /// </summary>
        /// <param name="transaction">Financial transaction with the value, category and type</param>
        /// <returns>Returns Task Completed always, need to be improved</returns>
        public async Task AddNewTransaction(TransactionDTO transaction)
        {
            Transaction financialTransaction = new(transaction.Type, transaction.Value, transaction.Category);

            await repositoryData.AddTransaction(financialTransaction);
        }
    }
}
