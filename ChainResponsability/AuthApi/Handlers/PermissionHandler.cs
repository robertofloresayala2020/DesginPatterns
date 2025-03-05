
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
namespace AuthAPI.Handlers
{

    public class PermissionHandler : AuthHandler
    {
        public override async Task<bool> HandleRequest(HttpContext context)
        {
            var username = context.Request.Headers["Username"].ToString();

            if (!string.IsNullOrEmpty(username) && HasPermission(username, "AccessResource"))
            {
               
                var token = GenerateJwtToken(username);
                context.Response.StatusCode = StatusCodes.Status200OK;
                await context.Response.WriteAsync(token);
                return true;
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Permission denied");
                return false;
            }
        }

         private bool HasPermission(string username, string permission)
        {
            // Simulate checking permissions from a database
            return true;
        }

        private string GenerateJwtToken(string username)
        {
            // Simulate generating a JWT token
            return "GeneratedJWTToken";
        }
    }
}