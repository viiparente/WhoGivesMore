using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhoGivesMore.Api.Models.Bid;

namespace WhoGivesMore.Api.Controllers
{
    [Route("api/bids")]
    [ApiController]
    public class BidsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBidModel model)
        {
            return NoContent();
        }

        [HttpGet("getHighestBid/{itemId?}")]
        public async Task<IActionResult> GetHighestBid(int itemId)
        {
            return Ok();
        }
    }
}
