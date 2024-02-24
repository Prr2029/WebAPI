using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class LogSheet
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogSheetId { get; set; }
        [ForeignKey("GetUser")]
        public int UserId { get; set; }

        public DateTime EndTime { get; set; }
        public string LogType {  get; set; }
        [ForeignKey("GetCourse")]
        public int CourseId { get; set; }
        [Required]
        [ForeignKey("GetSubject")]
        public int SubjectId { get; set; }
        [StringLength(50)]
        public string Topic { get; set; }
        public string verifiedBy { get; set; }
        public string ApprovedBy { get; set; }
        public User GetUser { get; set; } 
        public Subject GetSubject { get; set; }
        public Course GetCourse { get; set; }

        public override string ToString()
        {

        }
    }
}
