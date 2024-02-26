using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.configuration;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog= StudentSystem;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new StudentEntityTypeConfiguration().Configure(modelBuilder.Entity<Student>());
            new CourseEntityTypeConfiguration().Configure(modelBuilder.Entity<Course>());
            new ResourceEntityTypeConfiguration().Configure(modelBuilder.Entity<Resource>());
            new HomeworkEntityTypeConfiguration().Configure(modelBuilder.Entity<Homework>());
            new StudentCourseEntityTypeConfiguration().Configure(modelBuilder.Entity<StudentCourse>());
        }
    }
}
