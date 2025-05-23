using ApiGateway.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add the reverse proxy capability to the server
builder.Services.AddReverseProxy()
    // Initialize the reverse proxy from the "ReverseProxy" section of configuration
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

builder.Services.AddHttpClient();

var app = builder.Build();

// Register the reverse proxy routes
app.MapReverseProxy();

app.UseMiddleware<AuditLoggingMiddleware>();

app.Run();