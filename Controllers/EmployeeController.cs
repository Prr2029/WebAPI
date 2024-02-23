using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DatabaseContext;
using WebAPI.DTO;
using WebAPI.Model;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/User")]
   
    public class EmployeeController : ControllerBase
    {
        EmployeeService service;
        ProjectDbContext db;
        public EmployeeController(ProjectDbContext dbContext)
        {
            db = dbContext;
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

        [HttpPost("signup")]
        public void Post([FromBody] Signup model)
        {
            User user = new User();
           // user.EmailId = model.emailId;
            user.Password = model.password;
            user.MobileNo = model.mobileNo;
            db.users.Add(user);
            db.SaveChanges();

            
           // service.Add(user);





        }
      /*  [HttpPut("{id}")]
        public void Put(int id, [FromBody] ModifyEmpDTO empdto)
        {
            Employee tomodify = service.FindById(id);
            tomodify.EmpId = id;
            tomodify.FirstName = empdto.FirstName;
            tomodify.LastName = empdto.LastName;
            tomodify.HourlyRate = empdto.HourlyRate;
            tomodify.IsResigned = empdto.IsResigned;
            tomodify.ManagerId = empdto.ManagerId;
            tomodify.DeptId = empdto.DeptId;
            tomodify.DesignationId = empdto.DesignationId;
            tomodify.IsResigned = empdto.IsResigned;
            tomodify.UserId = empdto.UserId;
            service.Modify(tomodify);
        }*/


    }
}
