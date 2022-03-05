using WhoGivesMore.Core.Entities;
using WhoGivesMore.Core.Repositories;

namespace WhoGivesMore.Infrastructure.Persistence.Repositories
{
    public class BidRepository : IBidRepository
    {
        public Task AddAsync(Bid bid)
        {
            throw new NotImplementedException();
        }

        public Task<List<Bid>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsEligibleForBid()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
