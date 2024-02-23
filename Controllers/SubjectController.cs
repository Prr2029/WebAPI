using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public SubjectController() {
            service = new SubjectService();


        }


        [HttpGet]
        public IEnumerable<SubjectDTO> Get()
        {
            List<SubjectDTO> SubjectDTOList = new List<SubjectDTO>();
            foreach (Subject sub in service.GetAllSubjects())
            {
                SubjectDTO edl = new SubjectDTO();

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


            service.Add(subject);
        }

        [HttpPut("id")]
        public void put(int id, [FromBody]  SubjectDTO subDTO)

        {
            service.Put(id);


        }
        [HttpDelete("id")]
        public bool remove(int id)
        {
            //Subject sub = service.findById(id);
            service.Delete(id);
            return true;
        }
    }
}
