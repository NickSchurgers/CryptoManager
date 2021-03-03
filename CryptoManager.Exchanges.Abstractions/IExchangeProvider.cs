using CryptoManager.Exchanges.Models;
using System.Threading.Tasks;

namespace CryptoManager.Exchanges.KuCoin
{
    public interface IExchangeProvider
    {
        public Task<Portfolio> GetDefaultPortfolioAsync();
    }
}