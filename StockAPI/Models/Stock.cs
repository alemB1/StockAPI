using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Models
{
    [Table("Stocks")]
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty; // avoid null reference errorss
        public string CompanyName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Money { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }

        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();

    }
}
