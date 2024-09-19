using Filebin.Shared.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.Misc.Repository;

public abstract class CrudRepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class {
    protected abstract DbSet<TEntity> GetDbSet();
    protected abstract IQueryable<TEntity> StartQuery();

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
        return await StartQuery().ToListAsync(cancellationToken);
    }

    public async Task<IReadOnlyCollection<TEntity>> GetPageAsync(IPageDesc pageDesc, CancellationToken cancellationToken = default) {
        return await StartQuery()
            .Paginate(pageDesc)
            .ToListAsync(cancellationToken);
    }
}
