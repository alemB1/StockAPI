using Microsoft.EntityFrameworkCore;
using StockAPI.Data;
using StockAPI.Interfaces;
using StockAPI.Models;

namespace StockAPI.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comment.ToListAsync();
        }
    }
}
