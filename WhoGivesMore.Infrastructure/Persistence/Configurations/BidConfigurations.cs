using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhoGivesMore.Core.Entities;

namespace WhoGivesMore.Infrastructure.Persistence.Configurations
{
    public class BidConfigurations : IEntityTypeConfiguration<Bid>
    {
        public void Configure(EntityTypeBuilder<Bid> builder)
        {
            
            builder
                .HasKey(p => p.Id);

            builder
                .HasOne(p => p.Bidder)
                .WithMany(p => p.Bids)
                .HasForeignKey(p => p.IdBidder);

            
        }
    }
}
