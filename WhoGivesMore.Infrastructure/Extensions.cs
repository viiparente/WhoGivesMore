using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WhoGivesMore.Core.Repositories;
using WhoGivesMore.Infrastructure.Persistence;
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

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("WhoGivesMoreCs");

            services.AddDbContext<WhoGivesMoreDbContext>(options => options.UseSqlServer(connectionString));
            //services.AddDbContext<WhoGivesMoreDbContext>(options => options.UseInMemoryDatabase("WhoGivesMore"));

            return services;
        }
    }
}
