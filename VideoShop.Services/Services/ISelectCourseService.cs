using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
    public interface ISelectCourseService
    {
        int Add(SelectCourse appUser);

        void Delete(int id);

        void Update(SelectCourse appUser);

        SelectCourse Get(int id);

        List<SelectCourse> GetAll();
    }
}
