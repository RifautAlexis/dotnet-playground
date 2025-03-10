namespace AuditLog.models;

public class Log
{
    public DateTime Timestamp { get; set; }
    public PathString RequestPath { get; set; }
    public string HttpMethod { get; set; }
    public int ResponseStatusCode { get; set; }
    public string ClientIp { get; set; }
}