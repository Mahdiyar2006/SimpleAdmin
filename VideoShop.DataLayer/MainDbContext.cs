using Microsoft.EntityFrameworkCore;
using System;
using VideoShop.Core.Domains;
using VideoShop.Core.DomainsConfig;
namespace VideoShop.DataLayer
{
    public class MainDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=VideoShopDB;Trusted_Connection=True;MultipleActiveResultSets=true;user id=sa;password=mehrdad123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryCourseConfig());
            modelBuilder.ApplyConfiguration(new AppUserConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());
            modelBuilder.ApplyConfiguration(new SelectCourseConfig());

            DataSeeding.Seeding(modelBuilder);
        }

        public virtual DbSet<AppUser> AppUsers { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<SelectCourse> SelectCourses { get; set; }

        public virtual DbSet<CategoryCourse> CategoryCourses { get; set; }

      
    }
}
