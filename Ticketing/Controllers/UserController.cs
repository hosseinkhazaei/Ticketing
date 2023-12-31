using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Ticketing._01Core._03Contracts;
using Ticketing._01Core.Dto;
using Ticketing._01Core.Services;

namespace Ticketing.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        IUserServices _userServices;
        readonly IJWTManagerServices _jwtManagerServices;
        public UserController(IUserServices userServices, IJWTManagerServices jwtManagerServices)
        {
            _userServices = userServices;
            _jwtManagerServices = jwtManagerServices;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody] SimpleUserDto model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                var user = _userServices.Register(model);
                return Created(new Uri(Request.GetEncodedUrl() + "/" + user.Id), user);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] SimpleUserDto model)
        {
            try
            {
                var token = _jwtManagerServices.Authenticate(model);
                if (token == null)
                {
                    return Unauthorized();
                }

                return Ok(token);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


    }
}
