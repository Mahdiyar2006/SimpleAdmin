using System.Collections.Generic;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
    public interface IAppUserService
    {
        int Add(AppUser appUser);

        void Delete(int id);

        void Update(AppUser appUser);

        AppUser Get(int id);

        List<AppUser> GetAll();

    }
}
