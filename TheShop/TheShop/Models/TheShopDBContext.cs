﻿using Microsoft.EntityFrameworkCore;

namespace TheShop.Models
{
    public class TheShopDBContext: DbContext
    {
        public TheShopDBContext(DbContextOptions<TheShopDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }


    }
}