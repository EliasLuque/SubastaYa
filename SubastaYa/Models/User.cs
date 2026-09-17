using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SubastaYa.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = null!;
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        
        [Required]
        public string PasswordHash { get; set; } = null!;
       
        public DateTime RegistrationDate { get; set; }

        // Relación 1 a 1
        public Wallet Wallet { get; set; } = null!;

        // Relación 1 a muchos
        public ICollection<Auction> Auctions { get; set; } = null!;
        public ICollection<AuditLog> AuditLogs { get; set; } = null!;
        public ICollection<Bid> Bids { get; set; } = null!;

    }
}
