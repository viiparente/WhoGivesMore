using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhoGivesMore.Api.Models;

namespace WhoGivesMore.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            //Se não existir return NotFound

            return Ok();
        }

        // api/users
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] CreateUserModel createUserModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        // api/users/1/login
        [HttpPut("{id}/login")]
        public async Task<IActionResult> Login(int id, [FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
