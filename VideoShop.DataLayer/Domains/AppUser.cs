using System.Collections.Generic;

namespace VideoShop.Core.Domains
{
    public class AppUser
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public virtual ICollection<SelectCourse> SelectCourses { get; set; }
    }
}
