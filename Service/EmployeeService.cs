using WebAPI.DatabaseContext;
using WebAPI.Model;

namespace WebAPI.Service
{
    public class EmployeeService
    {

        ProjectDbContext db;
        public EmployeeService()
        {
            db = new ProjectDbContext();
        }
        public bool Add(Employee employee)
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
