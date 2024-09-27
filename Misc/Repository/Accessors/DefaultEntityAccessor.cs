using Filebin.Shared.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.Misc.Repository.Accessors;

public abstract class DefaultEntityAccessor : IEntityAccessor, IEntityObtainer
{
    public DbSet<T> GetDbSet<T>() where T : class {
        return GetDbContext().Set<T>();
    }

    protected abstract DbContext GetDbContext();

    public IQueryable<T> StartQuery<T>() where T : class {
        return GetDbSet<T>();
    }
}