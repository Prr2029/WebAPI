using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
    public class LogDTO
    {

        public int LogSheetId { get; set; }
     //public DateTime LogDateTime { get; set; }
        public string LogType { get; set; }

        public int UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
       
       
        
        
        public int SubjectId { get; set; }
        public int CourseId { get; set; }
        public string Topic { get; set; }
        




        
       

    }
}
