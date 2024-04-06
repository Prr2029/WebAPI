using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DatabaseContext;
using WebAPI.DTO;
using WebAPI.Model;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsheetController : ControllerBase
    {
        CourseService service;
        ProjectDbContext _db;
        public LogsheetController(ProjectDbContext db)
        {
            _db = db;
            
        }
        /* [HttpGet]
         public IEnumerable<LogSheetDTO> LogsheetByStaff(int id)

         {
             var result = _db.logsheets.Where(l => l.LogSheetId == id).ToList();
             return (IEnumerable<LogSheetDTO>)result;
         }*/

        [HttpGet]
        public ActionResult<IEnumerable<LogDTO>> Get()
        {
            var logSheetDTOs = _db.logsheets.Select(logSheet => new LogDTO
            {
                LogSheetId = logSheet.LogSheetId,
                UserId = logSheet.UserId,
                StartTime = logSheet.StartTime,
                EndTime = logSheet.EndTime,
                LogType = logSheet.LogType,
               // SubjectId = logSheet.SubjectId,
               // CourseId = logSheet.CourseId,
               // Topic = logSheet.Topic,
               // verifiedBy = logSheet.verifiedBy,
               // ApprovedBy = logSheet.ApprovedBy
            }).ToList();

            return logSheetDTOs;
        }
            
            
        




            [HttpPost]
        public bool AddLog([FromBody] LogSheetDTO logSheetDTO)
        {
            LogSheet log = new LogSheet();
            log.LogSheetId = logSheetDTO.LogSheetId;
            log.SubjectId = logSheetDTO.SubjectId;
            log.CourseId = logSheetDTO.CourseId;
            log.StartTime = logSheetDTO.StartTime;
            log.EndTime = logSheetDTO.EndTime;
            log.LogType = logSheetDTO.LogType;
            log.Topic = logSheetDTO.Topic;
            log.UserId  = logSheetDTO.UserId;
            _db.logsheets.Add(log);
            _db.SaveChanges();
            return true;
        }
    }
}
