using CryptoExchange.Net.Interfaces;
using System;
using System.Threading.Tasks;

namespace CryptoManager.Signals
{
    public interface ISignal
    {
        public event EventHandler<SignalReceivedEventArgs> SignalReceivedEvent;

        public int Weight { get; }

        public Task WatchAsync(ISocketClient websocketClient);
    }
}
