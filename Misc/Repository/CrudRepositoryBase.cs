using Filebin.Shared.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.Misc.Repository;

public class CrudRepositoryBase<T>(IEntityAccessor accessor, IEntityObtainer obtainer) : IRepository<T> where T : class {
    private readonly IEntityAccessor accessor = accessor;
    private IEntityObtainer obtainer = obtainer;

    public void UseObtainerAsDefault(IEntityObtainer otherObtainer) {
        obtainer = otherObtainer;
    }

    protected IQueryable<T> Query => obtainer.StartQuery<T>();
    protected DbSet<T> DbSet => accessor.GetDbSet<T>();

    public void Create(T entity) {
        DbSet.Add(entity);
    }

    public void Delete(T entity) {
        DbSet.Remove(entity);
    }

    public void Update(T entity) {
        DbSet.Update(entity);
    }

    public async Task<IReadOnlyCollection<T>> GetAllAsync(CancellationToken cancellationToken = default) {
        return await Query.ToListAsync(cancellationToken);
    }

    public async Task<IReadOnlyCollection<T>> GetPageAsync(IPageDesc pageDesc, CancellationToken cancellationToken = default) {
        return await Query.Paginate(pageDesc).ToListAsync(cancellationToken);
    }
}
