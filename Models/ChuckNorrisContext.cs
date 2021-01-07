using Microsoft.EntityFrameworkCore;

namespace cn_service.Models
{
    public class ChuckNorrisContext : DbContext
    {
        public ChuckNorrisContext(DbContextOptions<ChuckNorrisContext> options) : base(options)
        { }
        public DbSet<ChuckNorrisItem> ChuckNorrisItems { get; set; }
        
    }
}