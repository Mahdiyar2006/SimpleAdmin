using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using VideoShop.DataLayer;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly MainDbContext _mainDbContext;
        private readonly DbSet<Teacher> _appTeachers;

        public TeacherService()
        {
            _mainDbContext = new MainDbContext();
            _appTeachers = _mainDbContext.Set<Teacher>();
        }

        public int Add(Teacher appTeacher)
        {
            _appTeachers.Add(appTeacher);
            _mainDbContext.SaveChanges();

            return appTeacher.Id;
        }

        public void Delete(int id)
        {
            var entity = _appTeachers.Find(id);
            if (entity == null) return;
            _appTeachers.Remove(entity);
            _mainDbContext.SaveChanges();
        }

        public void Update(Teacher appTeacher)
        {
            var entity = _appTeachers.Find(appTeacher.Id);
            if (entity == null) return;
            entity.Name = appTeacher.Name;
            entity.Age = appTeacher.Age;
            entity.Address = appTeacher.Address;
            _mainDbContext.SaveChanges();
        }

        public Teacher GetAppTeacher(int id)
        {
            var entity = _appTeachers.Find(id);
            return entity;
        }

        public List<Teacher> GetTeachers()
        {
            return _appTeachers.ToList();
        }

        public List<Teacher> GetAll()
        {
            return _appTeachers.ToList();
        }
    }
}
