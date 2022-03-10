using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhoGivesMore.Api.Models;
using WhoGivesMore.Core.Entities;
using WhoGivesMore.Core.Repositories;

namespace WhoGivesMore.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(new CreateUserModel { FullName = user.FullName, BirthDate = user.BirthDate, Email = user.Email, Password = user.Password, Role = user.Role});
        }

        // api/users
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] CreateUserModel createUserModel)
        {
            var user = new User(createUserModel.FullName,createUserModel.Email,
                createUserModel.BirthDate,
                createUserModel.Password, createUserModel.Role);

            var id = await _userRepository.Create(user);

            return CreatedAtAction(nameof(GetById), new { id }, createUserModel);
        }

        // api/users/1/login
        [HttpPut("{id}/login")]
        public async Task<IActionResult> Login(int id, [FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
