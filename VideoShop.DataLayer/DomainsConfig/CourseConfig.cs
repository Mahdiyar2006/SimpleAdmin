using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoShop.Core.Domains;

namespace VideoShop.Core.DomainsConfig
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CourseName).HasMaxLength(50);

            builder.Property(p => p.CourseSubject).HasMaxLength(50);

            builder
                .HasOne(p => p.CategoryCourse)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.CategoryCourseId);


            builder
                .HasMany(p => p.SelectCourses)
                .WithOne(p => p.Course)
                .HasForeignKey(p => p.CourseId);
        }
    }
}
