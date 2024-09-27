namespace Filebin.Shared.Domain.Abstractions;

public interface IEntityObtainer<out T> where T : class {
    IQueryable<T> StartQuery();
}
