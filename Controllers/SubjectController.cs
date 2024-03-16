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
    public class SubjectController : ControllerBase
    {
        SubjectService service;
        private ProjectDbContext dbContext;
        public SubjectController(ProjectDbContext db) {
            dbContext = db;
            service = new SubjectService();


        }


        [HttpGet]
        public IEnumerable<SubjectDTO> Get()
        {
            List<SubjectDTO> SubjectDTOList = new List<SubjectDTO>();
            foreach (Subject sub in dbContext.subjects.ToList<Subject>())
            {
                SubjectDTO edl = new SubjectDTO();
                sub.SubjectName=    edl.SubjectName;
                sub.LabHrs = edl.LabHrs;
                sub.TheoryHrs=edl.TheoryHrs;

                SubjectDTOList.Add(edl);


            }
            return SubjectDTOList;


        }
        [HttpPost]
        public void post([FromBody]SubjectDTO subjectDTO) {
            Subject subject = new Subject();
            subject.SubjectName = subjectDTO.SubjectName;
            subject.LabHrs=subjectDTO.LabHrs;
            subject.TheoryHrs= subjectDTO.TheoryHrs;


            dbContext.subjects.Add(subject);
            dbContext.SaveChanges();
        }

        [HttpPut("id")]
        public bool put(int id, [FromBody]  SubjectDTO subDTO)

        {
            Subject sub = dbContext.subjects.Find(id);
            dbContext.subjects.Update(sub);
            return true;


        }
        [HttpDelete("id")]
        public bool remove(int id)
        {
            //Subject sub = service.findById(id);
            Subject sub = dbContext.subjects.Find(id);
            dbContext.subjects.Remove(sub);
            return true;
        }
    }
}
