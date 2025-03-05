using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AuthAPI.Handlers
{
    public class RoleHandler :  AuthHandler
    {

        public override async Task<bool> HandleRequest(HttpContext context)
        {
            var role = context.Request.Headers["Username"];
            if (role == "user" || role == "admin")
            {
                if (_nextHandler != null)
                {
                    await _nextHandler.HandleRequest(context);
                }
                return true;
            }

            else
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Authorization failed");
                return false;
            }
        }
        
    }

}