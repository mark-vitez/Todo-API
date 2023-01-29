using Newtonsoft.Json;

namespace TodoAPI.DTO
{
    public class GetTodoListResponse: BaseResponse
    {
        [JsonProperty("data")]
        public TodoListDTO Data { get; set; }        
    }
}