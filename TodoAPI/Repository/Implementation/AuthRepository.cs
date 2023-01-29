﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TodoAPI.Data;
using TodoAPI.DTO;
using TodoAPI.Repository.Contract;

namespace TodoAPI.Repository.Implementation
{
    public class AuthRepository : IAuthRepository
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;
        private readonly IConfiguration _configuration;
        private ApiUser _user;
        private const string _loginProvider = "TodoApi";
        private const string _refreshToken = "RefreshToken";

        public AuthRepository(IMapper mapper, UserManager<ApiUser> userManager, IConfiguration configuration)
        {
            this._mapper = mapper;
            this._userManager = userManager;
            this._configuration = configuration;
        }
        public async Task<IEnumerable<IdentityError>> Register(UserDto userDto)
        {
            _user = _mapper.Map<ApiUser>(userDto);
            _user.UserName = userDto.Email;  

            var result = await _userManager.CreateAsync(_user, userDto.Password);

            if (result.Succeeded) 
            {
                await _userManager.AddToRoleAsync(_user, "User");
            }

            return result.Errors;
        }

        public async Task<LoginResponseDTO> Login(UserDto loginDto)
        {
            _user = await _userManager.FindByEmailAsync(loginDto.Email);
            var isValid = await _userManager.CheckPasswordAsync(_user, loginDto.Password);
            if (_user == null || !isValid)
                return null;

            var token = await GenerateToken();
            var refreshToken = await CreateRefreshToken();
            return new LoginResponseDTO
            {
                UserId = _user.Id,
                Email = loginDto.Email,
                Token = token,
                RefreshToken = refreshToken
            };
        }

        private async Task<string> GenerateToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));

            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var roles = await _userManager.GetRolesAsync(_user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _userManager.GetClaimsAsync(_user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, _user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, _user.Email)
            }
            .Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<string> CreateRefreshToken()
        {
            await _userManager.RemoveAuthenticationTokenAsync(_user, _loginProvider, _refreshToken);
            var newRefreshToken = await _userManager.GenerateUserTokenAsync(_user, _loginProvider, _refreshToken);
            var result = await _userManager.SetAuthenticationTokenAsync(_user, _loginProvider, _refreshToken, newRefreshToken);
            return newRefreshToken;
        }

        public async Task<LoginResponseDTO> VerifyRefreshToken(LoginResponseDTO request)
        {
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenContent = jwtSecurityTokenHandler.ReadJwtToken(request.Token);
            var email = tokenContent.Claims.ToList().FirstOrDefault(Q => Q.Type == JwtRegisteredClaimNames.Email)?.Value;            
            _user = await _userManager.FindByEmailAsync(email);

            if (_user == null )
                return null;

            var isValidRefreshToken = await _userManager.VerifyUserTokenAsync(_user, _loginProvider, _refreshToken, request.RefreshToken);

            if (isValidRefreshToken) 
            {
                var token = await GenerateToken();
                return new LoginResponseDTO
                {
                    UserId = _user.Id,
                    Email = email,
                    Token = token,
                    RefreshToken = await CreateRefreshToken()
                };
            }

            await _userManager.UpdateSecurityStampAsync(_user);
            return null;
            
        }
    }
}
