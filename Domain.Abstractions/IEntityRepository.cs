namespace Filebin.Shared.Domain.Abstractions;

public interface IEntityRepository<T> : IRepository<T> where T : IEntity {
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken = default);
}
