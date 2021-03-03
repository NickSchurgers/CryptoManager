using CryptoManager.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoManager.Exchanges
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.AddScoped<IAssetRepository, AssetRepository>();
            services.AddScoped<IPortfolioRepository, PortfolioRepository>();

            return services;
        }
    }
}
