using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DatabaseContext;
using WebAPI.DTO;
using WebAPI.Model;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [Route("/course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        CourseService service;
        ProjectDbContext db;

        public CourseController(ProjectDbContext dbContext)
        {
            db = dbContext;
            service = new CourseService();
        }
        [HttpGet]
        public IEnumerable<GetCourseDTO> GetAllCourses()
        {
            List<GetCourseDTO> courseDTOList = new List<GetCourseDTO>();
            foreach (Course cour in service.GetAllCourse() )
            {
                GetCourseDTO cDTO = new GetCourseDTO();
                courseDTOList.Add( cDTO );
            }
            return courseDTOList;
        }
        [HttpPost]
        public void post([FromBody] AddCourseDTO coursetDTO)
        {
            Course course = new Course();
            course.CourseName= coursetDTO.CourseName;
            course.Duration= coursetDTO.Duration;
            service.AddCourse(course);
           
  
        }
        [HttpPut("id")]
        public void put(int id, [FromBody] SubjectDTO subDTO)

        {
            service.UpdateCourse(id);


        }
        [HttpDelete("id")]
        public bool remove(int id)
        {
            //Subject sub = service.findById(id);
            service.DeleteCourse(id);
            return true;
        }
    }
}
