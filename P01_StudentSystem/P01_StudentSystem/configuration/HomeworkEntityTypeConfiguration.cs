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
    internal class HomeworkEntityTypeConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.Property(e => e.Content)
                .IsUnicode(false);


            SeedHomeworks(builder);

        }
        private void SeedHomeworks(EntityTypeBuilder<Homework> builder)
        {
            builder.HasData(
                new Homework { HomeworkId = 1, Content = "Introduction to Programming Homework", ContentType = ContentType.Application, SubmissionTime = DateTime.Now, StudentId = 1, CourseId = 1 },
                new Homework { HomeworkId = 2, Content = "Database Design Homework", ContentType = ContentType.Pdf, SubmissionTime = DateTime.Now, StudentId = 2, CourseId = 2 },
                new Homework { HomeworkId = 3, Content = "Computer Network Homework", ContentType = ContentType.Pdf, SubmissionTime = DateTime.Now, StudentId = 3, CourseId = 3 }
            );
        }
    }
}
