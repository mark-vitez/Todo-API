using Microsoft.EntityFrameworkCore;
using TodoAPI.Repository.Contract;

namespace TodoAPI.Repository.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly TodoDBContext _context;

        public GenericRepository(TodoDBContext dBContext)
        {
            this._context = dBContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public async Task<bool> Exists(int id)
        {
            var entiry = await GetAsync(id);
            return entiry != null;

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            if (id == null) 
            {
                return null;
            }
            return await _context.Set<T>().FindAsync(id);
            
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
