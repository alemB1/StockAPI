using Microsoft.EntityFrameworkCore;
using StockAPI.Data;
using StockAPI.Interfaces;
using StockAPI.Models;

namespace StockAPI.Repository
{
    public class StockRepository : IStockRepository
    {
        private ApplicationDBContext _context;

        public StockRepository(ApplicationDBContext context)
        {
            _context = context;   
        }

        public Task<List<Stock>> GetAllAsync()
        {
            return  _context.Stock.ToListAsync();
        }
    }
}
