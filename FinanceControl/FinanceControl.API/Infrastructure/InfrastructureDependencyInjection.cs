using FinanceControl.Infrastructure.Interfaces;
using FinanceControl.Infrastructure.Repository;

namespace FinanceControl.API.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserTokenRepository, UserTokenRepository>();

            return services;
        }
    }
}
