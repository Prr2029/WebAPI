using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }
    }
}
