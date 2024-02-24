using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Model
{
    public class LabPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("getCourse")]
        public int CourseId { get; set; }
        [ForeignKey("getSubject")]
        public int  SubjectId { get; set; }
        [ForeignKey("getVerifiedBy")]
        public int verifiedId { get; set; }
        [ForeignKey("getApprovedBy")]
        public int ApprovedId { get; set; }
        public Course getCourse { get; set; }
        public Subject getSubject { get; set; }
        public LogSheet getVerifiedBy { get; set; }
        public LogSheet getApprovedBy { get; set; }

    }
}
