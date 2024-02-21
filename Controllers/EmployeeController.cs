using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DatabaseContext;
using WebAPI.DTO;
using WebAPI.Model;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class EmployeeController : ControllerBase
    {
        EmployeeService service;
        public EmployeeController()
        {
            service = new EmployeeService();
        }
        // GET: api/<EmployeeController>
        /*[HttpGet]
         public IEnumerable<Employee> Get()
         {
             return service.GetAllEmployees();
         }*/


        [HttpGet]
        public IEnumerable<EmpDTO> Get()
        {
            //return service.GetAllEmployees();
            List<EmpDTO> empDTOList = new List<EmpDTO>();
            foreach (Employee emp in service.GetAllEmployees())
            {
                EmpDTO edl = new EmpDTO();
                
                empDTOList.Add(edl);


            }
            return empDTOList;
        }

        // GET api/<EmployeeController>/5
        /*        [HttpGet("{id}")]
                public Employee GetById(int id)
                {
                    return service.FindById(id);
                }*/

       /* [HttpGet("{id}")]
        public EmpDTO GetById(int id)
        {
            Employee emp = service.FindById(id);
            EmpDTO empdto = new EmpDTO();
            empdto.EmpId = emp.EmpId;
           
            return empdto;
        }

        // POST api/<EmployeeController>
        /* [HttpPost]
         public void Post([FromBody] Employee emp)
         {
             service.Add(emp);
         }*/

        [HttpPost]
        public void Post([FromBody] AddEmpDTO empdto)
        {
            Employee emp = new Employee();

            
            emp.FirstName = empdto.FirstName;
           
            service.Add(emp);
        }


    }
}
