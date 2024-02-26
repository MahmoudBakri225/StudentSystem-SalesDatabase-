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
    internal class CourseEntityTypeConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(true);

            builder.Property(e => e.Description)
                .IsUnicode(true);

            builder.Property(e => e.Price)
            .HasColumnType("decimal(18,2)");

            SeedCourses(builder);

        }
        private void SeedCourses(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
                    new Course { CourseId = 1, Name = "Programming", Description = "Learning c#", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 2000.500m },
                    new Course { CourseId = 2, Name = "Database", Description = "Fundamentals of database design", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 500.500m },
                    new Course { CourseId = 3, Name = "Computer Network", Description = "The Fundamentals of Networking", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 1000.200m }
                );

        }
    }
}
