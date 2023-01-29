using Microsoft.AspNetCore.Mvc;
using TodoAPI.DTO;
using TodoAPI.Repository.Contract;

namespace TodoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthRepository _authManager;

        public AuthenticationController(IAuthRepository authManager)
        {
            this._authManager = authManager;
        }

        [HttpGet]
        [Route("ping")]
        public ActionResult Ping()
        {
            return Ok(new BaseResponse
            {
                State = SuccessState.Success,
                Message = "Server online"
            });
        }

        //Post: api/account/register
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<BaseResponse>> Register([FromBody] UserDto userDTO) 
        {
            var errors = await _authManager.Register(userDTO);
            if (errors.Any())
            {
                var errorMsg = "";
                foreach (var error in errors) 
                {
                    errorMsg += "error:code-" + error.Code + " msg-" +error.Description;
                }
                return BadRequest(new BaseResponse
                {
                    State = SuccessState.Fail,
                    Message = errorMsg
                });
            }

            return Ok(new BaseResponse
            {
                State = SuccessState.Success,
                Message = ""
            });
        }

        //Post: api/account/login
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<LoginResponse>> Login([FromBody] UserDto loginDto)
        {
            var authResponse = await _authManager.Login(loginDto);
            if (authResponse == null)
                return BadRequest( new LoginResponse{
                    Data = null,
                    State = SuccessState.Fail,
                    Message = "Incorrect login information." 
                });

            return Ok(
                new LoginResponse
                {
                    Data = authResponse,
                    State = SuccessState.Success,
                    Message = ""
                });   
        }

        //Post: api/account/login
        [HttpPost]
        [Route("refreshToken")]
        public async Task<ActionResult<LoginResponse>> RefreshToken([FromBody] LoginResponseDTO request)
        {
            var authResponse = await _authManager.VerifyRefreshToken(request);
            if (authResponse == null)
                return Ok(
                    new LoginResponse
                    {
                        Data = null,
                        State = SuccessState.Fail,
                        Message = "Token was not refreshed"
                    });
            return Ok(
                new LoginResponse
                {
                    Data = authResponse,
                    State = SuccessState.Success,
                    Message = ""
                });  
        }
    }
}
