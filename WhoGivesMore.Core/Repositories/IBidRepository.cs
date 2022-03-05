using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoGivesMore.Core.Entities;

namespace WhoGivesMore.Core.Repositories
{
    public interface IBidRepository
    {
        Task<List<Bid>> GetAllAsync();
        Task AddAsync(Bid bid);
        Task <bool> IsEligibleForBid();
        Task SaveChangesAsync();
    }
}
