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

    }
}
