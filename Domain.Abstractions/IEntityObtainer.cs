namespace Filebin.Shared.Domain.Abstractions;

public interface IEntityObtainer  {
    IQueryable<T> StartQuery<T>() where T : class;
}
