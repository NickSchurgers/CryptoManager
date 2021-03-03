using CryptoExchange.Net.Interfaces;
using System;
using System.Threading.Tasks;

namespace CryptoManager.Signals
{
    public abstract class Signal : ISignal
    {
        public int Weight { get; private set; }

        public event EventHandler<SignalReceivedEventArgs> SignalReceivedEvent;

        public abstract Task WatchAsync(ISocketClient websocketClient);

        protected Signal(int weight)
        {
            Weight = weight;
        }

        protected void onSignalReceived(SignalType type)
        {
            SignalReceivedEvent?.Invoke(this, new SignalReceivedEventArgs(type, Weight));
        }
    }
}
