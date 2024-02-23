using WebAPI.DatabaseContext;
using WebAPI.Model;

namespace WebAPI.Service
{
    public class EmployeeService
    {

        ProjectDbContext db=null;

        public EmployeeService()
        {
        }

        public EmployeeService(ProjectDbContext dbContext )
        {
            db = dbContext;
        }
        public bool Add(User employee)
        {
            db.Add(employee);
            db.SaveChanges();
            return true;

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees.ToList<Employee>();

        }
       /* public void Modify(Employee employee)
        {
            Console.WriteLine(employee);
            Employee tobeModify = db.Employees.Where(emps => employee.DeptId == emps.DeptId).ToList().FirstOrDefault<Employee>();
            tobeModify.FirstName = employee.FirstName;
            tobeModify.LastName = employee.LastName;
            tobeModify.DesignationId = employee.DesignationId;
            tobeModify.IsResigned = employee.IsResigned;
            *//* tobeModify.HourlyRate = employee.HourlyRate;
             tobeModify.DeptId = employee.DeptId;
             tobeModify.ManagerId = employee.ManagerId;*//*
            Console.WriteLine(tobeModify);
            db.SaveChanges();

        }*/

    }
}
