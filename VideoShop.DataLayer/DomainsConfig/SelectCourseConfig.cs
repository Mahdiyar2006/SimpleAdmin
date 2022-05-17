using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Core.Domains;

namespace VideoShop.Core.DomainsConfig
{
    public class SelectCourseConfig : IEntityTypeConfiguration<SelectCourse>
    {
        public void Configure(EntityTypeBuilder<SelectCourse> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .HasOne(p => p.Course)
                .WithMany(p => p.SelectCourses)
                .HasForeignKey(p => p.CourseId);
            builder
                .HasOne(p => p.AppUser)
                .WithMany(p => p.SelectCourses)
                .HasForeignKey(p => p.AppUserId);
                
        }
    }
}
