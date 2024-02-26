using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.configuration
{
    internal class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(true);

            builder.Property(e => e.Description)
            .HasMaxLength(250)
            .IsRequired()
            .HasDefaultValue("No description");

            ProductStudents(builder);
        }
        private void ProductStudents(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                  new Product { ProductId = 1, Name = "computer", Quantity = 100.0, Price = 10000.00m, Description= "No description" },
                  new Product { ProductId = 2, Name = "mobile", Quantity = 100.0, Price = 6000.00m, Description = "No description" }
                    );

        }
    }

}
