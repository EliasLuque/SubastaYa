using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SubastaYa.Models
{
    public enum StateType
    {   
        SCHEDULED,
        ACTIVE,
        COMPLETED,
        DESERTED
    }

    public class Auction
    {
        [Key]
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string? Title { get; set; }
        public string Desctiption { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public decimal BasePrice { get; set; }
        public decimal MinimunIncrement { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public StateType State { get; set; }

        // Optimistic Locking
        [ConcurrencyCheck]
        public int Version { get; set; }

        // Colecciones para la relación 1 a muchos
        public ICollection<Bid> Bids { get; set; } = null!;
        public ICollection<TransactionLedger> TransactionLedger { get; set; } = null!;
    }
}
