
namespace FitLog.Repositories
{
    public interface IRepositoryBase<T>
    {

        Task<List<T>> FindAllAsync();

        Task<T> FindByIdAsync(long id);

        Task CreateAsync(T entity);

        Task DeleteAsync(long id);

        Task UpdateAsync(T entity);
    }
}
