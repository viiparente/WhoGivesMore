using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoGivesMore.Core.Enums;

namespace WhoGivesMore.Core.Entities
{
    public class Item : BaseEntity
    {
        public Item(string title,
                    string description,
                    decimal startingPrice,
                    decimal minIncrease,
                    DateTime startTime,
                    DateTime endTime,
                    int idOwner)
        {
            Title = title;
            Description = description;
            StartingPrice = startingPrice;
            MinIncrease = minIncrease;
            CreatedAt = DateTime.Now;
            StartTime = startTime;
            EndTime = endTime;


            CreatedBy = idOwner;
            LastModified = DateTime.Now;
            Status = ItemStatusEnum.Created;

            Bids = new List<Bid>();
        }


        public string Title { get; private set; }
        public string Description { get; private set; }
        public int CreatedBy { get; private set; }
        public decimal StartingPrice { get; private set; }
        public decimal MinIncrease { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public DateTime? LastModified { get; private set; }
        public int LastModifiedBy { get; private set; }
        public ItemStatusEnum Status { get; private set; }


        public int IdBid { get; private set; }
        public List<Bid> Bids { get; private set; }


        public int IdBidder { get; private set; }
        public User Bidder { get; private set; }


        public int IdOwner { get; private set; }
        public User Owner { get; private set; }

        public void Start()
        {
            if (ItemStatusEnum.Created == Status)
            {
                if (StartTime.Ticks >= DateTime.Now.Ticks)
                {
                    Status = ItemStatusEnum.InProgress;
                    //TODO: Verificar
                }
            }
        }

        public void Update(string title, string description, decimal startingPrice, decimal minIncrease, DateTime startTime, DateTime endTime, int idOwner)
        {
            Title = title;
            Description = description;
            StartingPrice = startingPrice;
            MinIncrease = minIncrease;
            StartTime = startTime;
            EndTime = endTime;

            LastModifiedBy = idOwner;
            LastModified = DateTime.Now;
        }

    }
}
