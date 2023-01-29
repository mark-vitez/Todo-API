using Newtonsoft.Json;

namespace TodoAPI.DTO
{
    public class SetTaskStateDTO
    {
        [JsonProperty("taskId")]
        public int TaskId { get; set; }
        [JsonProperty("state")]
        public bool State { get; set; }   

    }
}
