using StockAPI.Models;

namespace StockAPI.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
    }
}
