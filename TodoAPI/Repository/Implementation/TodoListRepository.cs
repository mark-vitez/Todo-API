using Microsoft.EntityFrameworkCore;
using TodoAPI.Data;
using TodoAPI.Repository.Contract;

namespace TodoAPI.Repository.Implementation
{
    public class TodoListRepository : GenericRepository<TodoList>, ITodoListRepository
    {
        private TodoDBContext _dbContext;
        public TodoListRepository(TodoDBContext dBContext) : base(dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<IEnumerable<TodoList>> GetUserTodoLists(string userId)
        {
            var todoLists = await _dbContext.Set<TodoList>().Where(x => x.UserId == userId).ToListAsync();
            _dbContext.Lists.Include(x => x.TodoTasks).ToList();
            return todoLists;
        }

        public async Task<TodoList> GetList(string userId, int listId)
        {
            var todoList = await _dbContext.Lists.Include(x => x.TodoTasks).Where(x => x.Id == listId && x.UserId == userId).FirstOrDefaultAsync();
            return todoList;
        }

        public async Task CreateList(string userId, string listName) 
        {
            _dbContext.Lists.Add(new TodoList
            {
                UserId = userId,
                Name = listName,
                CreationDate = DateTime.Now                
            });
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteList(string userId, int listId)
        {
            var todoList = await _dbContext.Lists.Where(x => x.Id == listId && x.UserId == userId).FirstOrDefaultAsync();

            if (todoList != null)
            {
                _dbContext.Lists.Remove(todoList);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else 
            {
                return false;
            }
        }
    }    
}
