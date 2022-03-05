using WhoGivesMore.Core.Entities;

namespace WhoGivesMore.Core.Repositories
{
    public interface IItemRepository
    {
        Task<List<Item>> GetAllAsync();
        Task<List<Item>> GetQueryAsync(string query);
        Task<Item> GetDetailsByIdAsync(int id);
        Task<Item> GetByIdAsync(int id);
        Task AddAsync(Item item);
        Task UpdateAsync(Item item);
        Task DeleteAsync(int id);
        Task AddBidAsync(Bid bid);
        Task SaveChangesAsync();
    }
}
