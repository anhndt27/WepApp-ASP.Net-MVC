using Microsoft.EntityFrameworkCore;
using WebAppFinal.DataLayer.Entities;
using WebAppFinal.DTOs;
using WebAppFinal.BusinessLayer.DTOs.CourseQueryDto;
using WebAppFinal.DTOs.Reponse;

namespace WebAppFinal.DataLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentID, e.CourseID });

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.StudentID);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.CourseID);

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }        
        public DbSet<WebAppFinal.BusinessLayer.DTOs.CourseQueryDto.CourseRequestDto>? CourseRequestDto { get; set; }
        public DbSet<WebAppFinal.DTOs.Reponse.CourseDTO>? CourseDTO { get; set; }
    }
}
