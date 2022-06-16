using Microsoft.AspNetCore.Mvc;
using JourneyPlatform.Repositories;
using JourneyPlatform.DataTransferObjects;
using JourneyPlatform.Models;
namespace JourneyPlatform.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IUserRepository _repository;
        public AuthController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };
            
            return Created("success", _repository.Create(user));
        }
    }
}