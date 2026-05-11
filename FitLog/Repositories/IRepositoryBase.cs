using FitLog.Model;

namespace FitLog.Repositories
{
    public interface IRepositoryBase<T>
    {

        Task<List<T>> FindAllAsync();

        Task<T> FindByIdAsync(long id);

        Task CreateAsync(T entity);

        Task SaveChangesAsync();

        Task DeleteAsync(T entity);
    }
}
