using WhoGivesMore.Core.Entities;
using WhoGivesMore.Core.Repositories;

namespace WhoGivesMore.Infrastructure.Persistence.Repositories
{
    public class ItemRepository : IItemRepository
    {
        public Task AddAsync(Item item)
        {
            throw new NotImplementedException();
        }

        public Task AddBidAsync(Bid bid)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetDetailsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetQueryAsync(string query)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
