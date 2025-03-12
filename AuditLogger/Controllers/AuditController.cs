using AuditLogger.models;
using Microsoft.AspNetCore.Mvc;

namespace AuditLogger.Controllers;

[ApiController]
[Route("audit")]
public class AuditController : ControllerBase
{
    private readonly IAuditService _auditService;

    public AuditController(IAuditService auditService)
    {
        _auditService = auditService;
    }

    [HttpPost]
    public IActionResult CreateAudit([FromBody] AuditLogEntryDto dto)
    {
        var audit = _auditService.AddAuditLog(dto);
        return Ok(audit);
    }
}