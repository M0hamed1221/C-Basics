using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EF_Core_002.Entities;
using Microsoft.EntityFrameworkCore;
namespace EF_Core_002.Contexts
{
    class ITIDBContext:DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ITI;Trusted_Connection=True;TrustServerCertificate=True;");




        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent api 

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Department>().Property(d => d.Name).IsRequired().HasMaxLength(100);

           
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Course>().Property(c => c.Name).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<Course>().Property(c => c.Description).HasMaxLength(500);
          
        
            modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

           
            modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
            modelBuilder.Entity<Department>().HasMany(D => D.Instructors)
                                             .WithOne(i => i.Department)
                                             .HasForeignKey(i=>i.Dept_ID)
                                             .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }


    }


}
