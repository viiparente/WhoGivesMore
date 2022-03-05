namespace WhoGivesMore.Api.Models.Move
{
    public class CreateMoveModel
    {
        public decimal Amount { get; set; }

        public int ItemId { get; set; }

        public string UserId { get; set; }
    }
}
