using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoGivesMore.Core.Entities
{
    public class Bid : BaseEntity
    {
        public decimal Amount { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public int? ItemId { get; set; }
        public Item Item { get; set; }
    }
}
