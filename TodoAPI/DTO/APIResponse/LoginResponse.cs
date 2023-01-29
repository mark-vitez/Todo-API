using Newtonsoft.Json;

namespace TodoAPI.DTO
{
    public class LoginResponse: BaseResponse
    {
        [JsonProperty("data")]
        public LoginResponseDTO Data { get; set; }      
    }
}
