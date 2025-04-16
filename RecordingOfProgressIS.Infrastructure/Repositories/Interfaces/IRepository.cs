namespace RecordingOfProgressIS.Infrastructure.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        Task Add(T entity);
        Task<T> Get(int Id, Func<int, T> predicate);
        Task<IEnumerable<T>> GetAll();
        Task Update(T entity);
        Task Remove(IEnumerable<T> entities);
    }
}
