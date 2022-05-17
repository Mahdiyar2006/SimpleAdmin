using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VideoShop.DataLayer;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly MainDbContext _mainDbContext;
        private readonly DbSet<AppUser> _appUsers;

        public AppUserService()
        {
            _mainDbContext = new MainDbContext();
            _appUsers = _mainDbContext.Set<AppUser>();
        }


        public int Add(AppUser appUser)
        {
            _appUsers.Add(appUser);

            _mainDbContext.SaveChanges();

            return appUser.Id;
        }


        public void Delete(int id)
        {
            var entity = _appUsers.Find(id);

            if (entity == null) return;

            _appUsers.Remove(entity);

            _mainDbContext.SaveChanges();

        }

        public void Update(AppUser appUser)
        {
            var entity = _appUsers.Find(appUser.Id);
            entity.FirstName = appUser.FirstName;
            entity.LastName = appUser.LastName;
            entity.UserName = appUser.UserName;
            entity.Password = appUser.Password;
            _mainDbContext.SaveChanges();
        }

        public AppUser Get(int id)
        {
            var entity = _appUsers.Find(id);

            return entity;
        }
        public List<AppUser> GetAll()
        {
            return _appUsers.ToList();
        }
    }
}
