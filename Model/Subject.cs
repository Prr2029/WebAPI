using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int TheoryHrs { get; set; }
        public int LabHrs { get; set; }
    }
}
