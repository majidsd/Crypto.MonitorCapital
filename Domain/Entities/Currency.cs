using Domain.Common;

namespace Domain.Entities;

internal class Currency : AuditTableEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Abbreviation { get; set; }
    public decimal Amount { get; set; }
    public decimal LastPrice { get; set; }
}
