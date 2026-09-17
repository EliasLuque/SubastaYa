using System.ComponentModel.DataAnnotations;

namespace SubastaYa.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? IconUrl { get; set; }

        // Coleccion para la relación 1 a muchos
        public ICollection<Auction> Auctions { get; set; } = null!;
    }
}
