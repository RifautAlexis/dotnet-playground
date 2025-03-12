using System.IO;
using AuditLogger.models;
using Serilog;

public interface IAuditService
{
    IResult AddAuditLog(AuditLogEntryDto logEntry);
}

public class AuditService : IAuditService
{
    public IResult AddAuditLog(AuditLogEntryDto logEntry)
    {
        var logEntryText = $"{logEntry.HttpMethod} {logEntry.RequestPath} from {logEntry.ClientIp} with response {logEntry.ResponseStatusCode}";
        
        Log.Information(logEntryText);
        
        return Results.Ok();
    }
}