using StayCation.Hotel.Models.Models;


namespace StayCation.Hotel.Core.DTO
{
    public class TransactionDto
    {
        public string TransactionDetails { get; set; }
        public string status { get; set; }
        public Payment Payment { get; set; }
    }
}
