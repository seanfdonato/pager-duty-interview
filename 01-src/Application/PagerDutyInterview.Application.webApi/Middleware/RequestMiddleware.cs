using System.Net;

namespace Application.WebApi.Middleware
{
    public class RequestMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                int statutosCode = DefineStatusCode(ex);
                context.Response.StatusCode = statutosCode;
            }
        }

        private static int DefineStatusCode(Exception ex)
        {
            return ex switch
            {
                UnauthorizedAccessException => (int)HttpStatusCode.Unauthorized,
                _ => (int)HttpStatusCode.InternalServerError
            };
        }
    }
}
