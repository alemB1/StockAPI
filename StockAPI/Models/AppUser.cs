﻿using Microsoft.AspNetCore.Identity;

namespace StockAPI.Models
{
    public class AppUser:IdentityUser
    {
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();

    }
}
