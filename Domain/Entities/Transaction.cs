using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Transaction : AuditTableEntity
{
    public int Id { get; set; }
    public Currency? FilledCryptocurrency { get; set; }
    public TransactionTypes TransactionType { get; set; }
    public decimal Price { get; set; }
    public decimal FilledAmount { get; set; }
    public decimal Fee { get; set; }
    public decimal Total { get; set; }
    public Currency? PaidCryptocurrency { get; set; }
}
