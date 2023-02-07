using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Core.Consts;

namespace Api.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        // Get Current User Id via JWT Claims Identity
        protected int GetUserId()
        {
            var claimsIdentity = this.User.Identity as ClaimsIdentity;
            return int.Parse(claimsIdentity.FindFirst(StaticVariables.UserId)?.Value ?? "0");
        }
    }
}