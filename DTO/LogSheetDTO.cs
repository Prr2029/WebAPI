using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
    public class LogSheetDTO
    {
        
        public int LogSheetId { get; set; }
        public DateTime LogDateTime { get; set; }
        public string LogType {  get; set; }
        
        public int SubjectId { get; set; }
        
        public string Topic { get; set; }
        public string verifiedBy { get; set; }
        public string ApprovedBy { get; set; }

        public override string ToString()
        {
            return $"logId: {LogSheetId}, datetime: {LogDateTime},subId:{SubjectId}";
        }
    }
}
