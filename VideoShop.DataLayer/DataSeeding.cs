using Microsoft.EntityFrameworkCore;
using VideoShop.Core.Domains;

namespace VideoShop.DataLayer
{
    public static class DataSeeding
    {

        public static void Seeding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser 
                { 
                    Id = 1, 
                    FirstName = "Javad",
                    LastName = "HJAbadi",
                    Password = EncryptionHelper.GetSha256Hash("123456"),
                    UserName = "javad",
                });
        }
    }
}
