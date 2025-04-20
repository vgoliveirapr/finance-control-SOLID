using FinanceControl.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceControl.Infrastructure.Context
{
    public class FinanceControlDbContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserToken> UserTokens { get; set; }

        public FinanceControlDbContext(DbContextOptions<FinanceControlDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // All the configurations for the Transaction entity
            modelBuilder.Entity<Transaction>(t =>
            {
                t.ToTable("Transactions");
                t.HasKey(t => t.ID);
                t.Property(t => t.Type).IsRequired().HasMaxLength(1).HasColumnType("nvarchar");
                t.Property(t => t.Value).IsRequired().HasPrecision(15,2).HasColumnType("decimal");
                t.Property(t => t.Category).IsRequired().HasMaxLength(50).HasColumnType("nvarchar");
                t.Property(t => t.RegistrationDate).IsRequired().HasColumnType("timestamp");
            });    
            
            modelBuilder.Entity<User>(u =>
            {
                u.ToTable("Users");
                u.HasKey(u => u.IdUser);
                u.Property(u => u.Name).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
                u.Property(u => u.Username).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
                u.Property(u => u.PasswordEncrypted).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
                u.Property(u => u.IsActive).IsRequired().HasMaxLength(1).HasColumnType("nvarchar");
                u.Property(u => u.RegistrationDate).IsRequired().HasColumnType("timestamp");
            });

            modelBuilder.Entity<UserToken>(ut =>
            {
                ut.ToTable("UserTokens");
                ut.HasKey(ut => ut.IdUser);
                ut.Property(ut => ut.IdUser).IsRequired();
                ut.Property(ut => ut.Token).IsRequired().HasMaxLength(300).HasColumnType("nvarchar");
                ut.Property(u => u.CreationDate).IsRequired().HasColumnType("timestamp");
                ut.Property(u => u.ExpirationDate).IsRequired().HasColumnType("timestamp");
            });

            modelBuilder.Entity<UserToken>()
                .HasOne(ut => ut.User)
                .WithMany(ut => ut.UserTokens)
                .HasForeignKey(ut => ut.IdUser)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);

        }
    }
}
