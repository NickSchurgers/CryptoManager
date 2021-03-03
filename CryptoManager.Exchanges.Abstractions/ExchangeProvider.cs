using CryptoExchange.Net.ExchangeInterfaces;
using CryptoExchange.Net.Objects;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace CryptoManager.Exchanges
{
    public abstract class ExchangeProvider<TClient, TClientOptions> 
        where TClient : IExchangeClient, IDisposable, new()
        where TClientOptions : RestClientOptions
    {
        private readonly IOptions<TClientOptions> _options;

        protected ExchangeProvider(IOptions<TClientOptions> options)
        {
            _options = options;
        }

        protected Task<WebCallResult<TResult>> executeTask<TResult>(Func<TClient, Task<WebCallResult<TResult>>> func) 
        {
            using var client = (TClient)Activator.CreateInstance(typeof(TClient), _options.Value);
            return func(client);
        }
    }
}
