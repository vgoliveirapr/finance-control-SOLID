using FinanceControl.Infrastructure.Interfaces;
using FinanceControl.Infrastructure.Repository;

namespace FinanceControl.API.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            return services;
        }
    }
}
