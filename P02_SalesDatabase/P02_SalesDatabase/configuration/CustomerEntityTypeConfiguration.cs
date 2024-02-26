using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_SalesDatabase.Data;
using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.configuration
{
    internal class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.Name)
               .HasMaxLength(100)
               .IsUnicode(true);

            builder.Property(e => e.Email)
              .HasMaxLength(80)
              .IsUnicode(false);

            SeedCustomer(builder);
        }
        private void SeedCustomer(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                  new Customer { CustomerId = 1, Name = "Mahmoud Bakri", Email = "MahmoudBakri@example.com", CreditCardNumber = "1234-5678-9012-3456" },
                  new Customer { CustomerId = 2, Name = "Ahmed Mohamed", Email = "AhmedMohamed@example.com", CreditCardNumber = "9876-5432-1098-7654" }
                    );

        }
    }
}
