using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure.Context
{
    public class FinanceControlDbContextFactory : IDesignTimeDbContextFactory<FinanceControlDbContext>
    {
        public FinanceControlDbContext CreateDbContext(string[] args)
        {
            // Configurar a Connection String manualmente para o tempo de design
            var optionsBuilder = new DbContextOptionsBuilder<FinanceControlDbContext>();
            optionsBuilder.UseMySql(Environment.GetEnvironmentVariable("FINANCE_DB_CONNECTION"),
                new MySqlServerVersion(new Version(11, 7,2)));

            return new FinanceControlDbContext(optionsBuilder.Options);
        }
    }
}
