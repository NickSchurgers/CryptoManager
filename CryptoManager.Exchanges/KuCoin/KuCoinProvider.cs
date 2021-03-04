namespace CryptoManager.Exchanges.KuCoin
{
    using Kucoin.Net;
    using Kucoin.Net.Objects;
    using Microsoft.Extensions.Options;

    public class KuCoinProvider : ExchangeProvider<KucoinClient, KucoinSocketClient, KucoinClientOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KuCoinProvider"/> class.
        /// </summary>
        /// <param name="options">Options object.</param>
        public KuCoinProvider(IOptions<KucoinClientOptions> options)
            : base(options)
        {
        }
    }
}
