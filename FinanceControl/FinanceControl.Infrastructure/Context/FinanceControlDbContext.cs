using FinanceControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure.Context
{
    public class FinanceControlDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public FinanceControlDbContext(DbContextOptions<FinanceControlDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // All the configurations for the Transaction entity
            modelBuilder.Entity<Transaction>(t =>
            {
                t.ToTable("Transactions");
                t.HasKey(t => t.ID);
                t.Property(t => t.Type).IsRequired().HasMaxLength(1);
                t.Property(t => t.Value).IsRequired();
                t.Property(t => t.Category).IsRequired().HasMaxLength(50);
                t.Property(t => t.RegistrationDate).IsRequired();
            });            
                
        }
    }
}
