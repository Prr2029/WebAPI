using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public UserController()
        {
            service = new UserService();
        }


        [HttpPost]
        public void Post([FromBody] UserDTO userdto)
        {
            User user = new User();
            user.UserName = userdto.UserName;

            user.Email = userdto.Email;
            user.Password = userdto.Password;
            user.RoleId = userdto.RoleId;
            service.Add(user);




        }
        public IEnumerable<UserDTO> Get()
        {
            List<UserDTO> UserDTOList = new List<UserDTO>();
            foreach (User user in service.GetAllUsers())
            {
                UserDTO edl = new UserDTO();

                UserDTOList.Add(edl);


            }
            return UserDTOList;


        }
    }
}
