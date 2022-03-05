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
                    string userId)
        {
            Title = title;
            Description = description;
            StartingPrice = startingPrice;
            MinIncrease = minIncrease;
            CreatedAt = DateTime.Now;
            StartTime = startTime;
            EndTime = endTime;

            UserId = userId;

            Status = ItemStatusEnum.Created;

            Moves = new List<Move>();

            LastModifiedBy = userId;
            LastModified = DateTime.Now;
            CreatedBy = userId;
        }


        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal StartingPrice { get; private set; }
        public decimal MinIncrease { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public ItemStatusEnum Status { get; private set; }


        public string LastModifiedBy { get; private set; }
        public DateTime? LastModified { get; private set; }
        public string CreatedBy { get; private set; }

        List<Move> Moves { get; set; }

        public string UserId { get; private set; }
        public User User { get; private set; }





        public void Update(string title, string description, decimal startingPrice, decimal minIncrease, DateTime startTime, DateTime endTime, string userId)
        {
            Title = title;
            Description = description;
            StartingPrice = startingPrice;
            MinIncrease = minIncrease;
            StartTime = startTime;
            EndTime = endTime;

            LastModifiedBy = userId;
            LastModified = DateTime.Now;
        }

    }
}
