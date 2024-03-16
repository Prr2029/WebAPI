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
            service = new CourseService();
        }
        [HttpGet]
        public IEnumerable<LogSheetDTO> LogsheetByStaff(int id)

        {
            var result = _db.logsheets.Where(l => l.LogSheetId == id).ToList();
            return (IEnumerable<LogSheetDTO>)result;
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
