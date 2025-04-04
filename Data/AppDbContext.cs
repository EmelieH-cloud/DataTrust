﻿using DataTrust.Models;
using Microsoft.EntityFrameworkCore;

namespace DataTrust.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
    }
}
