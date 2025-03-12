using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.File(
        ".\\Logs\\.log",
        outputTemplate: "[{Timestamp:HH:mm:ss}] {Message:lj}{NewLine}{Exception}",
        rollingInterval: RollingInterval.Day)
    .CreateLogger();

// builder.Logging.ClearProviders();
// Log.CloseAndFlush();


builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IAuditService, AuditService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();