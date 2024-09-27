using Microsoft.EntityFrameworkCore;

namespace Filebin.Shared.Domain.Abstractions;

public interface IEntityAccessor {
    DbSet<T> GetDbSet<T>() where T : class;
}
