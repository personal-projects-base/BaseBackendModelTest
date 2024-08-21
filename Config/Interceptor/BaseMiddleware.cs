using System.Text;

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
        await _next.Invoke(httpContext);
    }
}