namespace MyWebApi;

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class MockAuthenticationMiddleware
{
    private readonly RequestDelegate _next;

    public MockAuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Headers.ContainsKey("Authorization") &&
            context.Request.Headers["Authorization"] == "Bearer MockToken")
        {
            await _next(context);
        }
        else
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        }
    }
}
