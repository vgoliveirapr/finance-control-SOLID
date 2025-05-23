﻿// <auto-generated />
using System;
using FinanceControl.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinanceControl.Infrastructure.Migrations
{
    [DbContext(typeof(FinanceControlDbContext))]
    partial class FinanceControlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("FinanceControl.Domain.Entities.Transaction", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar");

                    b.Property<decimal>("Value")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal");

                    b.HasKey("ID");

                    b.ToTable("Transactions", (string)null);
                });

            modelBuilder.Entity("FinanceControl.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("IsActive")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<string>("PasswordEncrypted")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdUser");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("FinanceControl.Domain.Entities.UserToken", b =>
                {
                    b.Property<Guid>("IdUser")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp");

                    b.Property<Guid>("IdUserToken")
                        .HasColumnType("char(36)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar");

                    b.HasKey("IdUser");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("FinanceControl.Domain.Entities.UserToken", b =>
                {
                    b.HasOne("FinanceControl.Domain.Entities.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinanceControl.Domain.Entities.User", b =>
                {
                    b.Navigation("UserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
