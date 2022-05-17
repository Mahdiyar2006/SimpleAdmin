
using System.Collections.Generic;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
    public interface ITeacherService
    {
        int Add(Teacher appTeacher);
        void Delete(int id);
        Teacher GetAppTeacher(int id);

        List<Teacher> GetAll();
    }
}
