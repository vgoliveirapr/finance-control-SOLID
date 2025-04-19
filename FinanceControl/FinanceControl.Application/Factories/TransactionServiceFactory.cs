using FinanceControl.Application.Interfaces;
using FinanceControl.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceControl.Application.Factories
{
    public class TransactionServiceFactory
    {
        private readonly IServiceProvider serviceProvider;

        public TransactionServiceFactory(IServiceProvider service)
        {
            serviceProvider = service;
        }

        public ITransactionService CreateService(string typeFinancialTransaction)
            => typeFinancialTransaction.ToLower() switch
            {
                "c" => serviceProvider.GetRequiredService<TransactionCreditService>(),
                "d" => serviceProvider.GetRequiredService<TransactionDebitService>(),
                _ => throw new ArgumentException("Financial transaction informed is not allowed")
            };
    }
}
