using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WhoGivesMore.Core.Entities;
using WhoGivesMore.Core.Repositories;

namespace WhoGivesMore.Infrastructure.Persistence.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly WhoGivesMoreDbContext _dbContext;
        public ItemRepository(WhoGivesMoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task AddAsync(Item item)
        {
            await _dbContext.Items.AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddBidAsync(Bid bid)
        {
            await _dbContext.Bids.AddAsync(bid);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var itemToRemove = await _dbContext.Items.SingleOrDefaultAsync(x => x.Id == id); //returns a single item.

            if (itemToRemove != null)
            {
                _dbContext.Items.Remove(itemToRemove);
                _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Item>> GetAllAsync()
        {
            return await _dbContext.Items.ToListAsync();
        }

        public Task<List<Bid>> GetAllBidAsync(int IdItem)
        {
            throw new NotImplementedException();
        }

        public async Task<Item> GetByIdAsync(int id)
        {
            return await _dbContext.Items
                .Include(b => b.Bids) //TODO: Verificar
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Item> GetDetailsByIdAsync(int id)
        {
            return await _dbContext.Items
               //.Include(p => p.Owner)
               //.Include(p => p.Bidder)
               .Include(p => p.Bids) //TODO: verificar
               .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Item>> GetQueryAsync(string query)
        {
            return await _dbContext.Items.Where(b => b.Title.Equals(query, StringComparison.OrdinalIgnoreCase)).ToListAsync();
        }

        public Task<bool> IsEligibleForBid(int IdItem)
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Item item)
        {
            _dbContext.Items.Update(item); // TODO: Incluir o update da camada core 

            await _dbContext.SaveChangesAsync();
        }
    }
}
