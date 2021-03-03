using CryptoManager.Exchanges.KuCoin;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;

namespace CryptoManager.Exchanges
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddExchanges(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddKuCoin(configuration);
        }

        private static IServiceCollection AddKuCoin(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<Kucoin.Net.Objects.KucoinClientOptions>().Configure(x => {
                var creds = configuration.GetSection("Kucoin:ApiCredentials").GetChildren();
                var key = creds.FirstOrDefault(x => x.Key == "Key").Value;
                var secret = creds.FirstOrDefault(x => x.Key == "Secret").Value;
                var passPhrase = creds.FirstOrDefault(x => x.Key == "PassPhrase").Value;
                x.ApiCredentials = new Kucoin.Net.Objects.KucoinApiCredentials(key, secret, passPhrase);
            });
            services.AddScoped<KuCoinProvider>();

            return services;
        }
    }
}
