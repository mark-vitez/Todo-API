namespace TodoAPI.Repository.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();        
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<bool> Exists(int id);
    }
}
