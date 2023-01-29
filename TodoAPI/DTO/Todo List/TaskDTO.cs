using Newtonsoft.Json;

namespace TodoAPI.DTO
{
    public class TaskDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("done")]
        public bool Done { get; set; }
    }
}
