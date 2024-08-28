using System.Text;
using Base_Backend.Gen;

namespace Base_Backend.Config;

public class BaseMiddleware
{
    
    private readonly RequestDelegate _next;
    
    public BaseMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task Invoke(HttpContext httpContext)
    {
        if (httpContext.Request.Headers.TryGetValue("x-tenant", out var headerValue))
        {
            CustomDbContext._asyncThread.Value = headerValue.ToString();
        }
        await _next.Invoke(httpContext);
    }
}