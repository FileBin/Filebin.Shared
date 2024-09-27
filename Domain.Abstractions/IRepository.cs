namespace Filebin.Shared.Domain.Abstractions;

public interface IRepository<T> where T : class {
    void UseObtainerAsDefault(IEntityObtainer<T> otherObtainer);

    Task<IReadOnlyCollection<T>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<T>> GetPageAsync(IPageDesc pageDesc, CancellationToken cancellationToken = default);

    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
