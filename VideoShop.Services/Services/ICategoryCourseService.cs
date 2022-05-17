using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoShop.Core.Domains;

namespace VideoShop.Services.Services
{
  public interface ICategoryCourseService
    {

        int Add(CategoryCourse appCategoryCourse);
        void Delete(int id);
        void Update(CategoryCourse appCategoryCourse);
        CategoryCourse Get(int id);

        List<CategoryCourse> GetAll();
    }
}
