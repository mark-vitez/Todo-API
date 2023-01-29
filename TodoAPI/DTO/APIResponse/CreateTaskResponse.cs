using Newtonsoft.Json;

namespace TodoAPI.DTO
{
    public class CreateTaskResponse: BaseResponse
    {
        [JsonProperty("data")]
        public CreateTaskResponseDTO Data { get; set; }
    }
}
