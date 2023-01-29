using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.DTO;
using TodoAPI.Repository.Contract;

namespace TodoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class TodoListsController : ControllerBase
    {
        private readonly ITodoListRepository _repository;
        private readonly IMapper _mapper;

        public TodoListsController(ITodoListRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        [HttpPost]
        [Route("createList")]
        public async Task<ActionResult<TodoListForUserResponse>> CreateList([FromBody] CreateListDTO list)
        {
            await _repository.CreateList(list.UserId, list.Name);
     
            return Ok(new BaseResponse
            {               
                State = SuccessState.Success,
                Message = ""
            });
        }

        [HttpGet]
        [Route("getUserLists")]
        public async Task<ActionResult<TodoListForUserResponse>> GetListsForUser(string userId)
        {
            var lists = await _repository.GetUserTodoLists(userId);
            var responseList = new List<TodoListDTO>();
            foreach (var item in lists)
            {
                var todoList = _mapper.Map<TodoListDTO>(item);
                todoList.Tasks = _mapper.Map<IEnumerable<TaskDTO>>(item.TodoTasks).ToList().OrderBy(x => x.CreationDate);
                responseList.Add(todoList);
            }
            return Ok(new TodoListForUserResponse
            {
                Data = _mapper.Map<IEnumerable<TodoListDTO>>(responseList),
                State = SuccessState.Success,
                Message = ""
            });
        }

        [HttpGet]
        [Route("getList")]
        public async Task<ActionResult<TodoListForUserResponse>> GetList(string userId, int listId)
        {
            var list = await _repository.GetList(userId, listId);

            if (list == null)
            {
                return NotFound(new GetTodoListResponse
                {
                    Data = null,
                    Message = "List not found",
                    State = SuccessState.Fail
                });
            }

            var responseList = _mapper.Map<TodoListDTO>(list);
            responseList.Tasks = _mapper.Map<IEnumerable<TaskDTO>>(list.TodoTasks).ToList().OrderBy(x => x.CreationDate);

            return Ok(new GetTodoListResponse
            {
                Data = responseList,
                State = SuccessState.Success,
                Message = ""
            });
        }

        [HttpDelete]
        [Route("deleteList")]
        public async Task<ActionResult<TodoListForUserResponse>> DeleteList(string userId, int listId)
        {
            var list = await _repository.DeleteList(userId, listId);

            if (list == true)
            {
                return Ok(new BaseResponse
                {
                    State = SuccessState.Success,
                    Message = ""
                });
            }
            else
            {
                return Ok(new BaseResponse
                {
                    State = SuccessState.Fail,
                    Message = "List ID not found for user"
                });
            }

        }
    }
    
}
