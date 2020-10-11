using FDMC.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FDMC.Data
{
    public class FDMCDbContext : DbContext
    {
        public FDMCDbContext(DbContextOptions<FDMCDbContext> options) : base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }
    }
}
