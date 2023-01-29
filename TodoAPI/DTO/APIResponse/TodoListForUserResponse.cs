using Newtonsoft.Json;

namespace TodoAPI.DTO
{
    public class TodoListForUserResponse: BaseResponse
    {
        [JsonProperty("data")]
        public IEnumerable<TodoListDTO> Data { get; set; }    
    }
}
