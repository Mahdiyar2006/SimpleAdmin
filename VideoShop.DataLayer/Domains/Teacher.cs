using System.Collections.Generic;

namespace VideoShop.Core.Domains
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}
