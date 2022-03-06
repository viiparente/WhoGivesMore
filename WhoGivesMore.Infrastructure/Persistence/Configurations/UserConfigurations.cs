using WhoGivesMore.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WhoGivesMore.Infrastructure.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(s => s.Id);

            //builder
            //    .HasMany(u => u.Bids)
            //    .WithOne()
            //    .HasForeignKey(u => u.IdBidder)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
