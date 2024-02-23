using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Model;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        UserRoleService uservice;
        public UserRoleController() {
            uservice = new UserRoleService();


        }

        [HttpGet]
          public IEnumerable<UserRole> Get()
          {
            List<RoleDTO> RoleDTOList = new List<RoleDTO>();
            foreach (Employee emp in service.GetAllRoles())
            {
                RoleDTO edl = new RoleDTO();

                RoleDTOList.Add(edl);


            }
            return RoleDTOList;
            
          }

    }
}
