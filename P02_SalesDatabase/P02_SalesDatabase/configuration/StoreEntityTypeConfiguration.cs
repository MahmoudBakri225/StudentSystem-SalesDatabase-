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
    internal class StoreEntityTypeConfiguration : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            SeedStore(builder);
        }
        private void SeedStore(EntityTypeBuilder<Store> builder)
        {
            builder.HasData(
                  new Store { StoreId = 1, Name = "Store1" },
                  new Store { StoreId = 2, Name = "Store2" }
                    );

        }
    }
}
