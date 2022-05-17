
using System.Collections.Generic;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
    public interface ICourseService
    {
        int Add(Course appCourse);
        void Delete(int id);
        void Update(Course appCourse);
        Course Get(int id);
        List<Course> GetAll();
    }
}
