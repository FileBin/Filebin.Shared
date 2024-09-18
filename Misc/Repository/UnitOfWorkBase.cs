using Filebin.Shared.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;
namespace Filebin.Shared.Misc.Repository;

public abstract class UnitOfWorkBase : IUnitOfWork {
    public abstract DbContext GetDbContext();

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) {
        return GetDbContext().SaveChangesAsync(cancellationToken);
    }
}
