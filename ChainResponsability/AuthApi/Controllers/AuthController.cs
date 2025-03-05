using Microsoft.AspNetCore.Mvc;
using AuthAPI.Handlers;

namespace AuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class  AuthController:ControllerBase
    {

        private  readonly AuthHandler _authHandler;

        public AuthController()
        {
           var usernamePasswordHandler  = new UsernamePasswordHandler();
           var roleHandler = new RoleHandler(); 
           var permissionHandler = new PermissionHandler();
           usernamePasswordHandler.SetNextHandler(roleHandler).SetNextHandler(permissionHandler);
           _authHandler = usernamePasswordHandler;
        }


       [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate()
        {
            await _authHandler.HandleRequest(HttpContext);
           
            if (HttpContext.Response.StatusCode == StatusCodes.Status200OK)
            {
                return Ok("Authentication successful.");
            }
            else if (HttpContext.Response.StatusCode == StatusCodes.Status401Unauthorized)
            {
                return Unauthorized("Authentication failedxx.");
            }
            else if (HttpContext.Response.StatusCode == StatusCodes.Status403Forbidden)
            {
                return Forbid("Authorization failed.");
            }
            else
            {
                return StatusCode(HttpContext.Response.StatusCode, "An error occurred.");
            }
           
        }

    }

}