using CryptoManager.Exchanges.KuCoin;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CryptoManager.CLI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .AddCommandLine(args)
                .Build();

            var serviceProvider = new ServiceCollection()
                .AddCryptoManager(configuration)
                .BuildServiceProvider();

            // TODO use command line args. services.GetService<IConfigurationRoot>() should give access to the arguments.
            var kucoinProvider = serviceProvider.GetService<KuCoinProvider>();
            Console.WriteLine((await kucoinProvider.GetDefaultPortfolioAsync()).Balance);
        }
    }
}
