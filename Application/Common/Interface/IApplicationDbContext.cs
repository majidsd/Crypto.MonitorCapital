
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interface;

internal interface IApplicationDbContext
{
    public DbSet<Currency> Currency { get; }
    public DbSet<Transaction> Transaction { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
