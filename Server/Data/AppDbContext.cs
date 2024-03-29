﻿using ECommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
