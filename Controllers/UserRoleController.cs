using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DTO;
using WebAPI.Model;
using WebAPI.Service;

namespace WebAPI.Controllers
{
    [Route("/userrole")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        UserRoleService uservice;
        public UserRoleController() {
            uservice = new UserRoleService();


        }

        [HttpGet]
          public IEnumerable<RoleDTO> Get()
          {
            List<RoleDTO> RoleDTOList = new List<RoleDTO>();
            foreach (UserRole urole in uservice.GetAllRoles())
            {
               RoleDTO edl = new RoleDTO();

                RoleDTOList.Add(edl);


            }
            return RoleDTOList;
          
            
          }

        [HttpPut("id")]
        public void put(int id,[FromBody]RoleDTO roleDTO)

        {
            uservice.Put(id);


        }

    }
}
