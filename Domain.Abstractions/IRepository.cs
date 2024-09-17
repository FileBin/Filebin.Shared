namespace Filebin.Shared.Domain.Abstractions;

public interface IRepository<T> {
    Task<IReadOnlyCollection<T>> GetAllAsync(CancellationToken cancellationToken = default);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
