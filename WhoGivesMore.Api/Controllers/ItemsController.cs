using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhoGivesMore.Api.Models.Item;

namespace WhoGivesMore.Api.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        // api/items?query=RTX3090TI
        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            return Ok();
        }

        // api/items/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        // api/items
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateItemModel item)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, item);
        }

        // api/items/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateItemModel item)
        {
            //se não exister e badrequest

            return NoContent();
        }

        // api/items/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return NoContent();
        }
    }
}
