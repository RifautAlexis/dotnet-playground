using AuditLog.models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/log", (Log payload) =>
    {
        Console.WriteLine(payload);
        Console.WriteLine("==================================");
        return Results.Ok();
    })
    .WithName("LogDynamicPayload");

app.Run();