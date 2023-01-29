using AutoMapper;
using TodoAPI.Data;
using TodoAPI.DTO;

namespace TodoAPI.Config
{
    public class AutomapperConfig: Profile
    {
        public AutomapperConfig()
        {
            CreateMap<TodoList, CreateListDTO>().ReverseMap();
            CreateMap<UserDto, ApiUser>().ReverseMap();
            CreateMap<TodoListDTO, TodoList>().ReverseMap();
            CreateMap<TodoTask, TaskDTO>().ReverseMap();
            CreateMap<TodoTask, CreateTaskResponseDTO>().ReverseMap();
        }
    }
}
