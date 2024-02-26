﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P02_SalesDatabase.Data;

#nullable disable

namespace P02_SalesDatabase.Migrations
{
    [DbContext(typeof(SalesContext))]
    partial class SalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P02_SalesDatabase.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("sales")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CreditCardNumber = "1234-5678-9012-3456",
                            Email = "MahmoudBakri@example.com",
                            Name = "Mahmoud Bakri",
                            sales = 0
                        },
                        new
                        {
                            CustomerId = 2,
                            CreditCardNumber = "9876-5432-1098-7654",
                            Email = "AhmedMohamed@example.com",
                            Name = "Ahmed Mohamed",
                            sales = 0
                        });
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasDefaultValue("No description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("sales")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "No description",
                            Name = "computer",
                            Price = 10000.00m,
                            Quantity = 100.0,
                            sales = 0
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "No description",
                            Name = "mobile",
                            Price = 6000.00m,
                            Quantity = 100.0,
                            sales = 0
                        });
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("SaleId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SaleId = 1,
                            CustomerId = 1,
                            Date = new DateTime(2024, 2, 26, 20, 13, 11, 395, DateTimeKind.Local).AddTicks(2475),
                            ProductId = 1,
                            StoreId = 1
                        },
                        new
                        {
                            SaleId = 2,
                            CustomerId = 2,
                            Date = new DateTime(2024, 2, 26, 20, 13, 11, 395, DateTimeKind.Local).AddTicks(2540),
                            ProductId = 2,
                            StoreId = 2
                        });
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sales")
                        .HasColumnType("int");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            StoreId = 1,
                            Name = "Store1",
                            sales = 0
                        },
                        new
                        {
                            StoreId = 2,
                            Name = "Store2",
                            sales = 0
                        });
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Sale", b =>
                {
                    b.HasOne("P02_SalesDatabase.Models.Customer", "Customer")
                        .WithMany("Saleslist")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P02_SalesDatabase.Models.Product", "Product")
                        .WithMany("Saleslist")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P02_SalesDatabase.Models.Store", "Store")
                        .WithMany("Saleslist")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Customer", b =>
                {
                    b.Navigation("Saleslist");
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Product", b =>
                {
                    b.Navigation("Saleslist");
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Store", b =>
                {
                    b.Navigation("Saleslist");
                });
#pragma warning restore 612, 618
        }
    }
}
