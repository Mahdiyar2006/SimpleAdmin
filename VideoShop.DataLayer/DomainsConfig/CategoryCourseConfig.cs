using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoShop.Core.Domains;


namespace VideoShop.Core.DomainsConfig
{
    class CategoryCourseConfig : IEntityTypeConfiguration<CategoryCourse>
    {
        public void Configure(EntityTypeBuilder<CategoryCourse> builder)
        {
            builder
                .Property(p => p.Title).HasMaxLength(50);
            builder
                .HasMany(p => p.Courses)
                .WithOne(p => p.CategoryCourse)
                .HasForeignKey(p => p.CategoryCourseId);
        }
    }
}
