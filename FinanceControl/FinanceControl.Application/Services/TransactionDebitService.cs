using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;

namespace FinanceControl.Application.Services
{
    public class TransactionDebitService : ITransactionService
    {
        private readonly List<Transaction> Data = new();

        /// <summary>
        /// Add the financial transaction to database
        /// </summary>
        /// <param name="transaction">Financial transaction with the value, category and type</param>
        /// <returns>Future implementation</returns>
        public async Task AddNewTransaction(TransactionDTO transaction)
        {
            Transaction financialTransaction = new(transaction.Type, -transaction.Value, transaction.Category);
            Data.Add(financialTransaction);
        }
    }
}
