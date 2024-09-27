using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.Domain.Abstractions;

public interface IEntityAccessor<T> where T : class {
    DbSet<T> GetDbSet();
}
