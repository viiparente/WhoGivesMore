namespace WhoGivesMore.Api.Models.Bid
{
    public class CreateBidModel
    {
        public decimal Amount { get; set; }

        public int ItemId { get; set; }

        public int UserId { get; set; }
    }
}
