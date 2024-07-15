using Microsoft.EntityFrameworkCore;
using StockAPI.Models;

namespace StockAPI.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }

        // ubuduce stavljaj u mnozini
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
