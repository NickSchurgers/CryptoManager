using CryptoManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CryptoManager.Data
{
    public class CryptoManagerDBContext : DbContext
    {
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Asset> Assets { get; set; }

        public CryptoManagerDBContext(DbContextOptions<CryptoManagerDBContext> options) : base(options)
        {
        }
    }
}
