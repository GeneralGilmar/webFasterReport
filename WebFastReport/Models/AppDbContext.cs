﻿using Microsoft.EntityFrameworkCore;

namespace WebFastReport.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {}
    public DbSet<Product> Products { get; set; }
}
