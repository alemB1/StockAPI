using StockAPI.Models;

namespace StockAPI.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync();

    }
}
