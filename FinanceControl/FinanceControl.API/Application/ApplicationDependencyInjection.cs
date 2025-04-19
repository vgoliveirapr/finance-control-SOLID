using FinanceControl.Application.Factories;
using FinanceControl.Application.Services;

namespace FinanceControl.API.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<DataRepositoryService>();
            services.AddScoped<TransactionCreditService>();
            services.AddScoped<TransactionDebitService>();
            services.AddScoped<TransactionServiceFactory>();

            return services;
        }
    }
}
