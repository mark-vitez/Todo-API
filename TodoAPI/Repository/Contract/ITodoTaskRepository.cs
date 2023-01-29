using TodoAPI.Data;

namespace TodoAPI.Repository.Contract
{
    public interface ITodoTaskRepository : IGenericRepository<TodoTask>
    {
        public Task<bool> SetState(int taskId, bool state);
    }
}
