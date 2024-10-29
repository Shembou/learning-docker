using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Site_Api.Entities;
using Site_Api.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Site_Api.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    public class AuthenticationController : Controller
    {
        private readonly AuthenticationRepository _authenticationRepository;

        private readonly IConfiguration _configuration;
        public AuthenticationController(AuthenticationRepository authenticationRepository, IConfiguration configuration)
        {
            _authenticationRepository = authenticationRepository;
            _configuration = configuration;
        }
        [HttpPost("authenticate")]
        public ActionResult<string> Authenticate(User user)
        {


            var result = _authenticationRepository.ValidateUserCredentials(user.UserName, user.Password);

            if (result == null)
            {
                return Unauthorized();
            }

            var securityKey = new SymmetricSecurityKey(Convert.FromBase64String(_configuration["Authentication:SecretForKey"]));

            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Authentication, user.UserName));
            claims.Add(new Claim(ClaimTypes.Hash, user.Password));

            var jwtSecurityToken = new JwtSecurityToken(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
                signingCredentials);

            var tokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            return Ok(tokenToReturn);
        }
    }
}
