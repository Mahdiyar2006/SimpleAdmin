using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Core.Domains;
using VideoShop.DataLayer;

namespace VideoShop.Services.Services
{
    public class SelectCourseService : ISelectCourseService
    {
        private readonly MainDbContext _mainDbContext;
        private readonly DbSet<SelectCourse> _selectCourse;

        public SelectCourseService()
        {
            _mainDbContext = new MainDbContext();
            _selectCourse = _mainDbContext.Set<SelectCourse>();
        }


        public int Add(SelectCourse selectCourse)
        {
            _selectCourse.Add(selectCourse);

            _mainDbContext.SaveChanges();

            return selectCourse.Id;
        }


        public void Delete(int id)
        {
            var entity = _selectCourse.Find(id);

            if (entity == null) return;

            _selectCourse.Remove(entity);

            _mainDbContext.SaveChanges();

        }

        public void Update(SelectCourse selectCourse)
        {
            var entity = _selectCourse.Find(selectCourse.Id);
            entity.CourseId = selectCourse.CourseId;
            entity.AppUserId = selectCourse.AppUserId;
            _mainDbContext.SaveChanges();
        }

        public SelectCourse Get(int id)
        {
            var entity = _selectCourse.Find(id);

            return entity;
        }
        public List<SelectCourse> GetAll()
        {
            return _selectCourse.ToList();
        }
    }
}
