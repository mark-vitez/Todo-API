
using TodoAPI.Data;
using TodoAPI.Repository.Contract;

namespace TodoAPI.Repository.Implementation
{

    public class TodoTaskRepository : GenericRepository<TodoTask>, ITodoTaskRepository
    {
        private TodoDBContext _dbContext;
        public TodoTaskRepository(TodoDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<bool> SetState(int taskId, bool state)
        {
            var task = await _dbContext.Tasks.FindAsync(taskId);
            if (task != null) {
                task.Done = state;
                var changes = await _dbContext.SaveChangesAsync();
                return changes > 0;
            }

            return false;
        }
    }
}
