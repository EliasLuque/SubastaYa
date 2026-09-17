using System.ComponentModel.DataAnnotations;

namespace SubastaYa.Models
{
    public class Bid
    {
        [Key]
        public int Id { get; set; }
        public int AuctionId { get; set; }
        public int SellerId { get; set; }
        public decimal Amount { get; set; }
        public DateTime BidDate { get; set; }
    }
}