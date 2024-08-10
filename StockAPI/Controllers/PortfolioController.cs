using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StockAPI.Extension;
using StockAPI.Interfaces;
using StockAPI.Models;

namespace StockAPI.Controllers
{
    [Route("api/portfolio")]
    [ApiController]
    public class PortfolioController:ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IStockRepository _stockRepo;
        private readonly IPortfolioRepository _portfolioRepo;
        public PortfolioController(UserManager<AppUser> userManager, IStockRepository stockRepo
            ,IPortfolioRepository portfolioRepository)
        {
            _userManager = userManager;
            _stockRepo = stockRepo;
            _portfolioRepo = portfolioRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetUserPortfolio() 
        {
            var username = User.GetUsername(); // get user from user manager
            var appUser = await _userManager.FindByNameAsync(username); // find the appUser so you can get the pair from join table
            var userPortfolio = await _portfolioRepo.GetUserPortfolio(appUser); // return the stock object

            return Ok(userPortfolio);
        }
    }
}
