namespace ApiGateway.Middleware;

public class AuditLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly HttpClient _httpClient;

    public AuditLoggingMiddleware(RequestDelegate next, IHttpClientFactory httpClientFactory)
    {
        _next = next;
        _httpClient = httpClientFactory.CreateClient();
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Capture request info
        var requestPath = context.Request.Path;
        var httpMethod = context.Request.Method;
        var clientIp = context.Connection.RemoteIpAddress?.ToString();

        await _next(context); // Proceed to the next middleware

        // Capture response info
        var responseStatusCode = context.Response.StatusCode;

        // Send log to audit service
        var logEntry = new
        {
            Timestamp = DateTime.UtcNow,
            RequestPath = requestPath,
            HttpMethod = httpMethod,
            ResponseStatusCode = responseStatusCode,
            ClientIp = clientIp
        };
        
        Console.WriteLine(logEntry);

        await _httpClient.PostAsJsonAsync("http://localhost:8004/log", logEntry);
    }
}