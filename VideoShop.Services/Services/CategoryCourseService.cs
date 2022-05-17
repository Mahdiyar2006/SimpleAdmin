using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.DataLayer;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
    public class CategoryCourseService : ICategoryCourseService
    {
        private readonly MainDbContext _mainDbContext;
        private readonly DbSet<CategoryCourse> _appCategoryCourse;

        public CategoryCourseService()
        {
            _mainDbContext = new MainDbContext();
          _appCategoryCourse = _mainDbContext.Set<CategoryCourse>();
        }

        public int Add(CategoryCourse appCategoryCourse)
        {
            _appCategoryCourse.Add(appCategoryCourse);
            _mainDbContext.SaveChanges();
            return appCategoryCourse.Id;
        }

        public void Delete(int id)
        {
            var entity = _appCategoryCourse.Find(id);
            if (entity == null) return;
           _appCategoryCourse.Remove(entity);
            _mainDbContext.SaveChanges();
        }

        public CategoryCourse Get(int id)
        {
            var entity = _appCategoryCourse.Find(id);
            return entity;
        }

        public List<CategoryCourse> GetAll()
        {
            return _appCategoryCourse.ToList();
        }

        public void Update(CategoryCourse appCategoryCourse)
        {
            var entity = _appCategoryCourse.Find(appCategoryCourse.Id);
            entity.Title = appCategoryCourse.Title;
            _mainDbContext.SaveChanges();
        }
    }
}
