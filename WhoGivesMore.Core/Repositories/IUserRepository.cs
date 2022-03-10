using WhoGivesMore.Core.Entities;

namespace WhoGivesMore.Core.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
        Task <int> Create(User inputModel);
    }
}
