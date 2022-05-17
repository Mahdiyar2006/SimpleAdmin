using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShop.Core.Domains
{
    public class SelectCourse
    {
        public int Id { get; set; }

        public AppUser AppUser { get; set; }

        public int AppUserId { get; set; }

        public Course Course { get; set; }

        public int CourseId { get; set; }
    }
}
