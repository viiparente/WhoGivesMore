using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhoGivesMore.Api.Models.Move;

namespace WhoGivesMore.Api.Controllers
{
    [Route("api/moves")]
    [ApiController]
    public class MovesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateMoveModel model)
        {
            return NoContent();
        }

        [HttpGet("getHighestMove/{itemId?}")]
        public async Task<IActionResult> GetHighestMove(int itemId)
        {
            return Ok();
        }
    }
}
