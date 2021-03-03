using CryptoManager.Data;
using CryptoManager.Exchanges;
using CryptoManager.Signals;
using CryptoManager.Trading;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoManager
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddCryptoManager(this IServiceCollection services, IConfiguration configuration)
        {
            // Setup DB.
            services
                .AddDatabase()
                .AddDbContext<CryptoManagerDBContext>(o => o.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

            services.AddExchanges(configuration);
            services.AddSignals();
            services.AddTrading();

            return services;
        }
    }
}
