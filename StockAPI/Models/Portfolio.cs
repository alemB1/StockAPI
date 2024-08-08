using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Models
{
    [Table("Protfolios")]
    public class Portfolio
    {
        public string AppUserId { get; set; }
        public int StockId { get; set; }
        public AppUser AppUser { get; set; } // navigation propery
        public Stock Stock { get; set; }
    }
}
