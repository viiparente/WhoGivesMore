using Microsoft.Extensions.DependencyInjection;
using WhoGivesMore.Core.Repositories;
using WhoGivesMore.Infrastructure.Persistence.Repositories;

namespace WhoGivesMore.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IBidRepository, BidRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
