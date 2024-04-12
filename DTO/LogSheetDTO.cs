using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebAPI.Model;

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
            
            
        


        

      
    }
}
