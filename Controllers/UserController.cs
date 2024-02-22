/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.DTO;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[auth]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // Controllers/AuthController.cs




        [HttpPost("signup")]
        public IActionResult SignUp([FromBody] Signup model)
        {
            User user = new User();
            user.EmailId = model.emailId;
            user.MobileNo = model.mobileNo;


            var result = _userManager.CreateAsync(user, model.password).Result;

            if (result.Succeeded)
            {
                return Ok(new { Message = "User registered successfully" });
            }

            return BadRequest(new { Message = "Error registering user", Errors = result.Errors });
        }


    }
*/