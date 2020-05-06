using Microsoft.EntityFrameworkCore;

namespace MtgDeckApi.Models
{
    public class MtgDeckApiContext : DbContext
    {
        public MtgDeckApiContext(DbContextOptions<MtgDeckApiContext> options) : base(options) {}

        public DbSet<UserModel> Users { get; set; }
        public DbSet<DeckModel> Decks { get; set; }
        public DbSet<CardModel> Cards { get; set; }
    }
}