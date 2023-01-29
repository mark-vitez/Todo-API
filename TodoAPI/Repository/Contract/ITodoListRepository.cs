using TodoAPI.Data;

namespace TodoAPI.Repository.Contract
{
    public interface ITodoListRepository : IGenericRepository<TodoList> 
    {
        Task<IEnumerable<TodoList>> GetUserTodoLists(string id);
        Task<TodoList> GetList(string userId, int listId);
        Task<bool> DeleteList(string userId, int listId);
        Task CreateList(string userId, string listName);
    }
}
 