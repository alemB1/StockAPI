using System.ComponentModel.DataAnnotations.Schema;

namespace StockAPI.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; }
        public decimal Money { get; set; }
        public decimal Purchase { get; set; }

        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }

        // sve osim id-a i komentara
    }
}
