using System.Threading.Tasks;

namespace CryptoManager.Trading
{
    public interface ITrader
    {
        public Task BuyLimitAsync();

        public Task SellLimitAsync();
    }
}
