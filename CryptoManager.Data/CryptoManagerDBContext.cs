namespace CryptoManager.Data
{
    using CryptoManager.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using System.IO;

    public class CryptoManagerDBContext : DbContext
    {
        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<Asset> Assets { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Exchange> Exchanges { get; set; }

        public CryptoManagerDBContext(DbContextOptions<CryptoManagerDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PortfolioAsset>()
                .HasKey(t => new { t.PortfolioId, t.AssetId });

            modelBuilder.Entity<PortfolioAsset>()
            .HasOne(pa => pa.Portfolio)
            .WithMany(p => p.PortfolioAssets)
            .HasForeignKey(pa => pa.PortfolioId);

            modelBuilder.Entity<PortfolioAsset>()
                .HasOne(pa => pa.Asset)
                .WithMany(a => a.PortfolioAssets)
                .HasForeignKey(pa => pa.AssetId);
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CryptoManagerDBContext>
    {
        public CryptoManagerDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../CryptoManager/appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<CryptoManagerDBContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlite(connectionString);
            return new CryptoManagerDBContext(builder.Options);
        }
    }
}
