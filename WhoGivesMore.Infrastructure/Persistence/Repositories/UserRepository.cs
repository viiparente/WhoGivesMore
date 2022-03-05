using WhoGivesMore.Core.Entities;
using WhoGivesMore.Core.Repositories;

namespace WhoGivesMore.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash)
        {
            throw new NotImplementedException();
        }
    }
}
