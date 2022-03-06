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
                .HasOne(i => i.Item)
                .WithMany(b => b.Bids)
                .HasForeignKey(i => i.IdItem)
                .OnDelete(DeleteBehavior.Restrict)
                /*.IsRequired() */;

            builder.HasOne(u => u.Bidder)
                .WithMany(b => b.Bids)
                .HasForeignKey(u => u.IdBidder)
                .OnDelete(DeleteBehavior.Restrict)
                /*.IsRequired() */;
        }
    }
}
