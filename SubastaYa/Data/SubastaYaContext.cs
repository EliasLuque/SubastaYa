using Microsoft.EntityFrameworkCore;
using SubastaYa.Models;

namespace SubastaYa.Data
{
    public class SubastaYaContext : DbContext
    {
        public SubastaYaContext(DbContextOptions<SubastaYaContext> options) : base(options) { }
        public DbSet<Auction> Auctions { get; set; } = null!;
        public DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public DbSet<Bid> Bids { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<TransactionLedger> TransactionLedger { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Wallet> Wallets { get; set; } = null!;
    }
}