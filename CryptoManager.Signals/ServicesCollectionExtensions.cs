using Microsoft.Extensions.DependencyInjection;

namespace CryptoManager.Signals
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddSignals(this IServiceCollection services)
        {
            return services;
        }
    }
}
