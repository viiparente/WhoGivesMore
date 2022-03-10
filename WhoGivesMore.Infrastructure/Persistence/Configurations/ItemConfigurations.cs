using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhoGivesMore.Core.Entities;

namespace WhoGivesMore.Infrastructure.Persistence.Configurations
{
    public class ItemConfigurations : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder
                .HasKey(i => i.Id);

            ////Owner Item Auction
            //builder
            //    .HasOne(i => i.Owner)
            //    .WithMany(i => i.OwnedItems)
            //    .HasForeignKey(p => p.IdOwner)
            //    .OnDelete(DeleteBehavior.Restrict)
            //    /*.IsRequired()*/; //TODO: Verificar se realmente e requerido!

            ////Bidder Item Auction
            //builder
            //    .HasOne(b => b.Bidder)
            //    .WithMany(f => f.ItemsBidding)
            //    .HasForeignKey(p => p.IdBidder)
            //    .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
