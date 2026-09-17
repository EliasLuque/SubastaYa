using System.ComponentModel.DataAnnotations;

namespace SubastaYa.Models
{
    public class AuditLog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Entity { get; set; }
        public int EntityId { get; set; }
        [Required]
        public string? Action { get; set; }
        public int UserId { get; set; }
        public string JsonDetail { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
