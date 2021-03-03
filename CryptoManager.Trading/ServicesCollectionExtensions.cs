using Microsoft.Extensions.DependencyInjection;

namespace CryptoManager.Trading
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddTrading(this IServiceCollection services)
        {
            return services;
        }
    }
}
