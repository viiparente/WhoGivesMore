using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhoGivesMore.Api.Models.Item;
using WhoGivesMore.Core.Entities;
using WhoGivesMore.Core.Repositories;

namespace WhoGivesMore.Api.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;
        public ItemsController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        // api/items?query=RTX3090TI
        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            var item = await _itemRepository.GetAllAsync();

            if (item == null)
            {
                return NotFound();
            }
            //TODO: retornar os inputmodel não a identidade
            return Ok(item);
        }

        // api/items/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _itemRepository.GetByIdAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // api/items
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateItemModel inputModel)
        {
            var item = new Item(
                inputModel.Title, 
                inputModel.Description,
                inputModel.StartingPrice, 
                inputModel.MinIncrease,
                inputModel.StartTime,
                inputModel.EndTime
                );

            await _itemRepository.AddAsync(item);

            return CreatedAtAction(nameof(GetById), new { id = item.Id }, inputModel);
        }

        // api/items/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateItemModel itemModel)
        {
            var item = await _itemRepository.GetByIdAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            item.Update(itemModel.Title,
                itemModel.Description,
                itemModel.StartingPrice,
                itemModel.MinIncrease,
                itemModel.StartTime,
                itemModel.EndTime);

            await _itemRepository.UpdateAsync(item);

            return NoContent();
        }

        // api/items/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            //nao precisa nada disso somente do delete la no item repository
            var itemToDelete = await _itemRepository.GetByIdAsync(id);

            if (itemToDelete == null)
            {
                NotFound();
            }

            await _itemRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
