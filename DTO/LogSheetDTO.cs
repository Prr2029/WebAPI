using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
    public class LogSheetDTO
    {
        
        public int LogSheetId { get; set; }
        public int UserId { get;set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string LogType {  get; set; }
        
        public int SubjectId { get; set; }
        public int CourseId { get; set; }
        
        public string Topic { get; set; }
        public int verifiedBy { get; set; }
        public int ApprovedBy { get; set; }

        public override string ToString()
        {
            return $"logId: {LogSheetId}, subId:{SubjectId}";
        }
    }
}
