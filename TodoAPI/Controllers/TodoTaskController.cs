using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoAPI.Data;
using TodoAPI.DTO;
using TodoAPI.Repository.Contract;

namespace TodoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class TodoTaskController : ControllerBase
    {
        private readonly ITodoTaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TodoTaskController(ITodoTaskRepository taskRepository, IMapper mapper)
        {
            this._taskRepository = taskRepository;
            this._mapper = mapper;
        }

        [HttpPost]
        [Route("createTask")]
        public async Task<ActionResult<CreateTaskResponse>> CreateTask([FromBody] CreateTaskDTO taskDTO) {
            var result = await _taskRepository.AddAsync(new TodoTask
            {
                CreationDate = DateTime.Now,
                Description = taskDTO.Description,
                Done = false,
                ListId = taskDTO.ListId
            });

            if (result == null) {
                return BadRequest(new CreateTaskResponse {
                    Data = null,
                    Message = "Could not create resource",
                    State = SuccessState.Fail
                });
            }

            return Ok(new CreateTaskResponse {
                Data = _mapper.Map<CreateTaskResponseDTO>(result),
                State = SuccessState.Success,
                Message = ""
            });
        }


        [HttpDelete]
        [Route("deleteTask")]
        public async Task<ActionResult<CreateTaskResponse>> DeleteTask(int taskId)
        {
            await _taskRepository.DeleteAsync(taskId);
            return Ok(new BaseResponse
            {                
                State = SuccessState.Success,
                Message = ""
            });
        }

        [HttpPatch]
        [Route(nameof(SetTaskState))]
        public async Task<ActionResult<CreateTaskResponse>> SetTaskState([FromBody] SetTaskStateDTO request)
        {
            var result = await _taskRepository.SetState(request.TaskId, request.State);

            if (result)
            {
                return Ok(new BaseResponse
                {
                    State = SuccessState.Success,
                    Message = ""
                });
            }
            else 
            {
                return BadRequest(new BaseResponse
                {
                    State = SuccessState.Fail,
                    Message = "No record was found or updated!"
                });
            }
           
        }


    }
}
