using Newtonsoft.Json;

namespace TodoAPI.DTO
{
    public class BaseResponse
    {
        [JsonProperty("state")]
        public SuccessState State { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
