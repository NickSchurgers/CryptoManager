using CryptoManager.Exchanges.Models;
using Kucoin.Net;
using Kucoin.Net.Objects;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;

namespace CryptoManager.Exchanges.KuCoin
{
    public class KuCoinProvider : ExchangeProvider<KucoinClient, KucoinClientOptions>, IExchangeProvider
    {
        public KuCoinProvider(IOptions<KucoinClientOptions> options) : base(options)
        {
        }

        public async Task<Portfolio> GetDefaultPortfolioAsync()
        {
            var data = await executeTask(x => x.GetAccountsAsync());

            // TODO figure out how the fuck to get the value of each currency.
            var assets = data.Data.Select(x => new Asset(x.Currency, x.Balance, 1));
            return new Portfolio("Default", assets);
        }
    }
}
