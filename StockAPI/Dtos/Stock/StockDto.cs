using StockAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Dtos.Stock
{
    public class StockDto
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public decimal Purchase { get; set; }
        public string CompanyName { get; set; }
        public decimal Money { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        //comments
    }
}
