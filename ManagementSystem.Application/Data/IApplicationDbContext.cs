
namespace ManagementSystem.Application.Data
{
    using ManagementSystem.Domain.Appeal;
    using ManagementSystem.Domain.Balance;
    using ManagementSystem.Domain.Entities.Announcement;
    using ManagementSystem.Domain.Users;
    using Microsoft.EntityFrameworkCore;
    internal interface IApplicationDbContext
    {
        DbSet<Appeal> Appeal { get; set; }
        DbSet<Balance> Balance { get; set; }
        DbSet<User> User { get; set; }
        DbSet<User> Comment { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
