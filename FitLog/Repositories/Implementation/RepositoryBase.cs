using FitLog.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace FitLog.Repositories.Implementation
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {

        protected readonly AppDbContext _context;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> FindByIdAsync(long id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> FindAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var entityFound = await FindByIdAsync(id);
            if(entityFound != null)
            {
                _context.Set<T>().Remove(entityFound);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
