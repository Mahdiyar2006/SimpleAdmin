using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoShop.Core.Domains;

namespace VideoShop.Core.DomainsConfig
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(p => p.Name)
                   .HasMaxLength(50);

            builder.Property(p => p.Address)
                   .HasMaxLength(300);

        }
    }
}
