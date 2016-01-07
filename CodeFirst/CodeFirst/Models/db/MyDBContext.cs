using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirst.Models.db
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
            : base("MyConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(p => p.StudentID)
                .HasOptional(p => p.Address);
            modelBuilder.Entity<Student>()
                .HasMany(p => p.Courses)
                .WithMany(p => p.Students)
                .Map(p =>
                {
                    p.ToTable("ABC");
                    p.MapLeftKey("StudentID");
                    p.MapRightKey("CourseID");
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}