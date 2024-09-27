using Filebin.Shared.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.Misc.Repository;

public abstract class EntityCrudRepositoryBase<T>(IEntityAccessor<T> accessor, IEntityObtainer<T> obtainer) 
: CrudRepositoryBase<T>(accessor, obtainer), IEntityRepository<T>
where T : class, IEntity {
    public Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) {
        return Query.SingleOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }

    public Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default) {
        return Query.AnyAsync(entity => entity.Id == id, cancellationToken);
    }
}
