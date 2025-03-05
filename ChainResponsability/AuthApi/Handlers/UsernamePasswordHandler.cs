using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AuthAPI.Handlers
{

    public class UsernamePasswordHandler : AuthHandler
    {
        public override async Task<bool> HandleRequest(HttpContext context)
        {

               var username = context.Request.Headers["Username"];
               var password = context.Request.Headers["Password"]; 

            if(username =="user" && password == "password")
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
                await context.Response.WriteAsync("Authentication failed");
                return false;
            }
           
        }
    }

}
