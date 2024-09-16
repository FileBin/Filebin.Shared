using Microsoft.EntityFrameworkCore.Storage;

namespace Filebin.Shared.Domain.Abstractions;

public interface IUnitOfWork {
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    void RevertChanges();

    public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);

}

