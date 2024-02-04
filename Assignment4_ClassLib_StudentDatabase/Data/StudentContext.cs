using Assignment4_ClassLib_StudentDatabase.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment4_ClassLib_StudentDatabase.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentID = 1, FirstName = "Nhi", LastName = "Nguyen", ClassOf = 2025, PhoneNumber = "5132887145" },
                new Student { StudentID = 2, FirstName = "Elena", LastName = "Dutch", ClassOf = 2026, PhoneNumber = "5133099222" },
                new Student { StudentID = 3, FirstName = "Queen", LastName = "Thomas", ClassOf = 2028, PhoneNumber = "6048891983" },
                new Student { StudentID = 4, FirstName = "Jack", LastName = "Thomas", ClassOf = 2018, PhoneNumber = "5132896788" },
                new Student { StudentID = 5, FirstName = "Mina", LastName = "Le", ClassOf = 2020, PhoneNumber = "5458398299" }
            ); ;
        }
    }
}
