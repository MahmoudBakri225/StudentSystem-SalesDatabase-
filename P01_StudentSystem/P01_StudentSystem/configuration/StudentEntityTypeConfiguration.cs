using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.configuration
{
    internal class StudentEntityTypeConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(100)
                . IsUnicode(true);

            builder.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .HasColumnType("char(10)")
            .IsUnicode(false);

            SeedStudents(builder);

        }
        private void SeedStudents(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(
                  new Student { StudentId = 1, Name = "Mahmoud Bakri", PhoneNumber = "0111236574", RegisteredOn = DateTime.Now, Birthday = new DateTime(1999, 1, 1) },
                  new Student { StudentId = 2, Name = "Mohamed Mahmoud", PhoneNumber = "0120458298", RegisteredOn = DateTime.Now, Birthday = new DateTime(1998, 2, 10) },
                  new Student { StudentId = 3, Name = "Ahmed Mahmoud", PhoneNumber = "0100458400", RegisteredOn = DateTime.Now, Birthday = new DateTime(2000, 10, 10) }
              );
        }
    }
}
