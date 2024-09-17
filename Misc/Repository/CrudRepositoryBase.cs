using Filebin.Shared.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.Misc.Repository;

public abstract class CrudRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class {
    internal abstract DbSet<TEntity> GetDbSet();

    public void Create(TEntity entity) {
        GetDbSet().Add(entity);
    }

    public void Delete(TEntity entity) {
        GetDbSet().Remove(entity);
    }

    public void Update(TEntity entity) {
        GetDbSet().Entry(entity).State = EntityState.Modified;
    }

    public async Task<IReadOnlyCollection<TEntity>> GetAllAsync(CancellationToken cancellationToken = default) {
        return await GetDbSet().AsNoTracking().ToListAsync(cancellationToken);
    }
}
