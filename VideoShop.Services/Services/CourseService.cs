using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VideoShop.DataLayer;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
    public class CourseService : ICourseService
    {
        private readonly MainDbContext _mainDbContext;
        private readonly DbSet<Course> _appCourse;

        public CourseService()
        {
            _mainDbContext = new MainDbContext();
            _appCourse = _mainDbContext.Set<Course>();
        }

        public int Add(Course appCourse)
        {
            _appCourse.Add(appCourse);
            _mainDbContext.SaveChanges();
            return appCourse.Id;
        }

        public void Delete(int id)
        {
            var entity = _appCourse.Find(id);
            if (entity == null) return;
            _appCourse.Remove(entity);
            _mainDbContext.SaveChanges();
        }

        public Course Get(int id)
        {
            var entity = _appCourse.Find(id);
            return entity;
        }

        public List<Course> GetAll()
        {
            return _appCourse.ToList();
        }

        public void Update(Course appCourse)
        {
            var entity = _appCourse.Find(appCourse.Id);
            entity.Content = appCourse.Content;
            entity.CourseName = appCourse.CourseName;
            entity.CourseSubject = appCourse.CourseSubject;
            entity.CategoryCourseId = appCourse.CategoryCourseId;
            entity.TeacherId = appCourse.TeacherId;
            _mainDbContext.SaveChanges();
        }
    }
}
