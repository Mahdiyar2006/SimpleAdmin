using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoShop.Core.Domains;

namespace VideoShop.Core.DomainsConfig
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
     

        public void Configure(EntityTypeBuilder<AppUser> builder)
        {

            builder
               .Property(p => p.FirstName)
               .HasMaxLength(50);

            builder
                .Property(p => p.LastName)
                .HasMaxLength(50);
            builder
                .HasMany(p => p.SelectCourses)
                .WithOne(p => p.AppUser)
                .HasForeignKey(p => p.AppUserId);
                
        }
    }
}
