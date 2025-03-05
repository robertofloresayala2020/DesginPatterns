namespace AuthAPI.Handlers
{
    public abstract class AuthHandler    
    {
         protected AuthHandler? _nextHandler;

         public  AuthHandler SetNextHandler(AuthHandler handler)
         {
            this._nextHandler = handler;    
            return handler;
         }

        public abstract Task<bool> HandleRequest(HttpContext context);
    }

}


