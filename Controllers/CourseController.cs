﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DatabaseContext;
using WebAPI.DTO.CourseDTO;
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
    }
}