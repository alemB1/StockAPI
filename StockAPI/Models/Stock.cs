namespace StockAPI.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty; // avoid null reference errorss
        public string CompanyName { get; set; }
    }
}
