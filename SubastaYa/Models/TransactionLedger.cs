using System.ComponentModel.DataAnnotations;

namespace SubastaYa.Models
{
    public enum TransactionType
    {
        DEPOSIT,
        RETENTION,
        RELEASE,
        PAYMENT,
        COLLECTION
    }
    public class TransactionLedger
    {
        [Key]
        public int Id { get; set; }
        public int WalletId { get; set; }
        public int AuctionId { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}