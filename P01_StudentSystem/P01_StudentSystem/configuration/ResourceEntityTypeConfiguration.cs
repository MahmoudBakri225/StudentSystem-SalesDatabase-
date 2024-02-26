using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.configuration
{
    internal class ResourceEntityTypeConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(e => e.Url)
                .IsUnicode(false);

           

            SeedResources(builder);
        }
        private void SeedResources(EntityTypeBuilder<Resource> builder)
        {
            builder.HasData(
                new Resource { ResourceId = 1, Name = "Fundamentals for Beginners video", Url = "http://example.com/video", ResourceType = ResourceType.Video, CourseId = 1 },
                new Resource { ResourceId = 2, Name = "Database design basics", Url = "http://example.com/document", ResourceType = ResourceType.Document, CourseId = 2 },
                new Resource { ResourceId = 3, Name = "Computer Fundamentals Tutorial", Url = "http://example.com/document1", ResourceType = ResourceType.Document, CourseId = 3 }
            );

        }
    }
}
