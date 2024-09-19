using Filebin.Shared.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.Misc.Repository;

public abstract class EntityCrudRepositoryBase<TEntity> : CrudRepositoryBase<TEntity>, IEntityRepository<TEntity>
    where TEntity : class, IEntity {
    public Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) {
        return StartQuery().SingleOrDefaultAsync(entity => entity.Id == id, cancellationToken);
    }

    public Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default) {
        return StartQuery().AnyAsync(entity => entity.Id == id, cancellationToken);
    }
}
