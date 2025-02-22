using FinanceControl.Domain.Entities;

namespace FinanceControl.Infraestructure.Repository
{
    public class TransactionRepository
    {
        private List<Transaction> Data = new();

        public TransactionRepository() { }

        /// <summary>
        /// Future implementation
        /// </summary>
        /// <param name="transaction">Future implementation</param>
        public void AddTransaction(Transaction transaction) => Data.Add(transaction);
    }
}
