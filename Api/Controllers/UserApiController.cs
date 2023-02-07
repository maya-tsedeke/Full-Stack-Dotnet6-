using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Core.Consts;
using Application.Models;
using Application.Abstract;
using Api.Controllers;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/V1")]
    public class UserController : BaseController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("signin")]
        public async Task<IActionResult> Authenticate([FromBody] UserLoginDto user)
        {
            try
            {
                var result = await _userService.Authenticate(user);
                if (!result.Status)
                    return NotFound(result.Response);
                return Ok(result.Response);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [AllowAnonymous]
        [HttpPost("signup")]
        public async Task<IActionResult> Register([FromBody] UserDto user)
        {
            try
            {
                var result = await _userService.Register(user);

                if (!result.Status)
                    return BadRequest(new { message = result.Response });

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet]
        [Authorize(Roles = RoleType.User, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("CurrentUser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            try
            {
                var userId = GetUserId();
                if (userId == 0)
                    return NotFound();
                else
                {
                    var user = await _userService.GetUserById(userId);
                    if (user == null)
                        return NotFound();
                    else
                        return Ok(user);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme
        [Authorize(Roles = RoleType.User, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("changePassword")]
        public async Task<IActionResult> ChangePassword([System.Web.Http.FromBody] ChangePasswordModelDto changePasswordModel)
        {
            try
            {
                changePasswordModel.UserId = GetUserId();
                var response = await _userService.ChangePassword(changePasswordModel);
                if (response == null)
                    return NotFound("User Not Found");

                if (!response.Status)
                    return BadRequest(new { message = response.Response });

                return Ok(response.Response);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }
    }
}