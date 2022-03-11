using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoGivesMore.Core.Entities
{
    public class Bid : BaseEntity
    {
        public Bid(decimal amount, int idBidder, int idItem)
        {
            Amount = amount;
            IdBidder = idBidder;
            IdItem = idItem;
        }
        public decimal Amount { get; private set; }

        public int IdBidder { get; private set; }
        public User Bidder { get; set; }

        public int IdItem { get; private set; }
        public Item Item { get; set; }
    }
}
