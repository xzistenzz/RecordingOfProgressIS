using Microsoft.EntityFrameworkCore;
using RecordingOfProgressIS.Infrastructure.Context;
using RecordingOfProgressIS.Infrastructure.Repositories.Interfaces;

namespace RecordingOfProgressIS.Infrastructure.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly RopisDbContext _context;

        public Repository(RopisDbContext context)
        {
            _context = context;
        }

        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T?> Get(int Id, Func<int, T>? predicate = null)
        {
            return await _context.Set<T>().FindAsync(predicate);
        }

        public async Task<IEnumerable<T>?> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Remove(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
