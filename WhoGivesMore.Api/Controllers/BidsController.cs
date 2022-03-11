using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhoGivesMore.Api.Models.Bid;
using WhoGivesMore.Core.Entities;
using WhoGivesMore.Core.Repositories;

namespace WhoGivesMore.Api.Controllers
{
    [Route("api/items/{itemId}/bids")]
    [ApiController]
    public class BidsController : ControllerBase
    {
        private readonly IItemRepository _bidRepository;
        public BidsController(IItemRepository bidRepository)
        {
            _bidRepository = bidRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(int itemId, CreateBidModel model)
        {
            var itemAuction = await _bidRepository.GetByIdAsync(itemId);

            if (itemAuction == null)
                return NotFound();

            var bid = new Bid(
                model.Amount,
                model.UserId,
                itemAuction.Id
            );

            await _bidRepository.AddBidAsync(bid);


            return NoContent();
        }

        [HttpGet("getHighestBid/{itemId?}")]
        private async Task<IActionResult> GetHighestBid(int itemId)
        {
            return Ok();
        }
    }
}
