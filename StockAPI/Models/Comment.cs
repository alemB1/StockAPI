namespace StockAPI.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string  Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        // convention for one to many r
        public int? StockId { get; set; } // navigation property
        public Stock? Stock { get; set; } 
        // etf will set this up

    }
}
