using Filebin.Shared.Domain.Abstractions;
using Filebin.Shared.Exceptions.Models;

namespace Filebin.Shared.Misc.Repository;

public static class RepositoryExtensions {

    public static async Task EnsureExistsAsync<T>(this IEntityRepository<T> repository, Guid id, CancellationToken cancellationToken = default) where T : class, IEntity {
        var exists = await repository.ExistsAsync(id, cancellationToken);

        if (!exists) {
            throw new NotFoundException($"{typeof(T).Name} with id {id} was not found");
        }
    }

    public static async Task<T> GetByIdOrThrow<T>(this IEntityRepository<T> repository, Guid id, CancellationToken cancellationToken = default) where T : class, IEntity {
        return await repository.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException($"{typeof(T).Name} with id {id} was not found");
    }

    public static async Task DeleteByIdAsync<T>(this IEntityRepository<T> repository, Guid id, CancellationToken cancellationToken = default) where T : class, IEntity {
        T entity = await repository.GetByIdOrThrow(id, cancellationToken);
        repository.Delete(entity);
    }
}