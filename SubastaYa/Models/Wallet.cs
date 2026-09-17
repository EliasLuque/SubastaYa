using System.ComponentModel.DataAnnotations;

namespace SubastaYa.Models
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal HeldBalance { get; set; }
        public decimal AvailableBalance { get; set; }

        // Optimistic Locking
        [ConcurrencyCheck]
        public int Version { get; set; }

        // Relación 1 a muchos
        public ICollection<TransactionLedger> TrasactionLedger { get; set; } = null!;
    }
}
