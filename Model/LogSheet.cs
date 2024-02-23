using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class LogSheet
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogSheetId { get; set; }
        public DateTime LogDateTime { get; set; }
        public string LogType {  get; set; }
        [Required]
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
        [StringLength(50)]
        public string Topic { get; set; }
        public string verifiedBy { get; set; }
        public string ApprovedBy { get; set; }

        public override string ToString()
        {
            return $"logId: {LogSheetId}, datetime: {LogDateTime},subId:{SubjectId}";
        }
    }
}
