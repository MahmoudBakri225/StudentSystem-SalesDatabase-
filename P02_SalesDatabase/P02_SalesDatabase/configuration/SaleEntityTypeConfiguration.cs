using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P02_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.configuration
{
    internal class SaleEntityTypeConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {

            builder.Property(s => s.Date)
                .HasColumnType("date")  
                .HasDefaultValueSql("GETDATE()");

            SeedSale(builder);
        }
        private void SeedSale(EntityTypeBuilder<Sale> builder)
        {
            builder.HasData(
                  new Sale { SaleId = 1, Date = DateTime.Now, ProductId = 1, CustomerId = 1, StoreId = 1 },
                  new Sale { SaleId = 2, Date = DateTime.Now, ProductId = 2, CustomerId = 2, StoreId = 2 }
                    );

        }
    }
}
