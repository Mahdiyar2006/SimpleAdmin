using System;
using System.Collections.Generic;
using System.Linq;


namespace VideoShop.Core.Domains
{
   public class CategoryCourse
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
