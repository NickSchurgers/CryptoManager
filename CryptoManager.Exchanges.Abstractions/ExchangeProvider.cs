namespace CryptoManager.Exchanges
{
    using System;
    using System.Threading.Tasks;
    using CryptoExchange.Net.ExchangeInterfaces;
    using CryptoExchange.Net.Interfaces;
    using CryptoExchange.Net.Objects;
    using Microsoft.Extensions.Options;

    public abstract class ExchangeProvider<TClient, TSocketClient, TClientOptions> : IExchangeProvider<TClient, TSocketClient>
        where TClient : IExchangeClient, IDisposable, new()
        where TSocketClient : ISocketClient
        where TClientOptions : RestClientOptions
    {
        private readonly IOptions<TClientOptions> options;

        public TClient Client { get; }

        public TSocketClient SocketClient { get; }

        protected ExchangeProvider(IOptions<TClientOptions> options)
        {
            this.options = options;
        }

        protected Task<WebCallResult<TResult>> ExecuteTask<TResult>(Func<TClient, Task<WebCallResult<TResult>>> func)
        {
            using var client = (TClient)Activator.CreateInstance(typeof(TClient), options.Value);
            return func(client);
        }
    }
}
