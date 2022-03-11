using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WhoGivesMore.Core.Entities;
using WhoGivesMore.Core.Repositories;

namespace WhoGivesMore.Infrastructure.Persistence.Repositories
{
    public class BidRepository : IBidRepository
    {
        private readonly WhoGivesMoreDbContext _dbContext;
        public BidRepository(WhoGivesMoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Bid bid)
        {
            await _dbContext.Bids.AddAsync(bid);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Bid>> GetAllAsync() => await _dbContext.Bids.ToListAsync();

        public async Task<bool> IsEligibleForBid(int IdItem)
        {
            return await _dbContext.Bids.AnyAsync(p => p.IdItem == IdItem);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
