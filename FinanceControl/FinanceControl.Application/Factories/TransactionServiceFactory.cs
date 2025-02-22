using FinanceControl.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                "d" => serviceProvider.GetRequiredService<TransactionCreditService>(),
                _ => throw new ArgumentException("Financial transaction informed is not allowed")
            };
    }
}
