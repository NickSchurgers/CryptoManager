using System.Threading.Tasks;

namespace CryptoManager.Trading
{
    public interface IBalancer
    {
        public Task BalanceAssetsAsync();

        public Task BalancePortfoliosAsync();

        public Task BalanceExchangesAsync();
    }
}
