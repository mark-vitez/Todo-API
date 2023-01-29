using Newtonsoft.Json;

namespace TodoAPI.DTO
{
    public class CreateTaskDTO
    {
        [JsonProperty("")]
        public string Description { get; set; }
        public int ListId { get; set; }
    }
}
