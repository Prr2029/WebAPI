using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class CourseSubject
    {
        public int CourseSubjectId { get; set; }
        [ForeignKey("GetCourse")]
        public int CourseId { get; set; }
        public Course GetCourse { get; set; }
        [ForeignKey("GetSubject")]
        public int SubjectId { get; set; }

        public Subject   GetSubject { get; set; }
        
    }
}
