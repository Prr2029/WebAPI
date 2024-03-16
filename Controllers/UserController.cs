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
    public class UserController : ControllerBase
    {
        UserService service;
        private ProjectDbContext _db;
        public UserController(ProjectDbContext db)
        {
            _db = db;
        }


        [HttpPost]
        public void Post([FromBody] UserDTO userdto)
        {
            User user = new User();
            user.UserName = userdto.UserName;

            user.Email = userdto.Email;
            user.Password = userdto.Password;
            user.MobileNo = userdto.MobileNo;
            user.RoleId = userdto.RoleId;
           // user.GetRole.RoleName=userdto.GetRole.RoleName;
            _db.users.Add(user);
            _db.SaveChanges();





        }
        [HttpGet]
        public IEnumerable<UserDTO> Get()
        {
             List<UserDTO> UserDTOList = new List<UserDTO>();
             foreach (User user in _db.users.ToList<User>())
             {
                 UserDTO edl = new UserDTO();
                  edl.UserName = user.UserName;
                    edl.Email = user.Email;
                    edl.Password = user.Password;
                    edl.RoleId = user.RoleId;
                edl.GetRole = user.GetRole;
                            

                 UserDTOList.Add(edl);


             }
             return UserDTOList;
         


        }
    }
}
