using StockAPI.Models;

namespace StockAPI.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>> GetUserPortfolio(AppUser user);
        Task<Portfolio> CreateAsync(Portfolio portfolio); // create bc in controller is bad practice
    }
}
