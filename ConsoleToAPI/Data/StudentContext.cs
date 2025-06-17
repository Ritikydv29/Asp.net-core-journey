
using ConsoleToAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ConsoleToAPI.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }
        public DbSet<Student>Student { get; set; }
        public DbSet<Teacher> Teacher{ get; set; }
        public DbSet<Score> Scores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(s => s.Student_Id);

            modelBuilder.Entity<Teacher>()
                .HasKey(t => t.Teacher_Id);

            modelBuilder.Entity<Score>()
                .HasKey(sc => sc.id);

            // Student-Teacher relationship
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Teacher)
                .WithMany(t => t.Students)
                .HasForeignKey(s => s.Teacher_Id);

            // Score-Student relationship
            modelBuilder.Entity<Score>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.Scores)
                .HasForeignKey(sc => sc.Student_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Score-Teacher relationship
            modelBuilder.Entity<Score>()
                .HasOne(sc => sc.Teacher)
                .WithMany(t => t.Scores)
                .HasForeignKey(sc => sc.Teacher_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
