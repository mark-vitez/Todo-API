

using Newtonsoft.Json;

namespace TodoAPI.DTO
{

    public class LoginResponseDTO
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("accessToken")]
        public string Token { get; set; }
        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }
    }
}
