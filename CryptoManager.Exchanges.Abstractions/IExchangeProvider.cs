namespace CryptoManager.Exchanges
{
    using System;
    using CryptoExchange.Net.ExchangeInterfaces;
    using CryptoExchange.Net.Interfaces;

    public interface IExchangeProvider<TExchangeClient, TSocketClient>
        where TExchangeClient : IExchangeClient, IDisposable, new()
        where TSocketClient : ISocketClient
    {
        TExchangeClient Client { get; }

        TSocketClient SocketClient { get; }
    }
}