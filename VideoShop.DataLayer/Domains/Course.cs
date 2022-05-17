using System.Collections.Generic;
namespace VideoShop.Core.Domains
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string CourseSubject { get; set; }

        public string Content { get; set; }
        
        public int TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }

        public int CategoryCourseId { get; set; }

        public CategoryCourse CategoryCourse { get; set; }

        public ICollection<SelectCourse> SelectCourses { get; set; }

    }
}
