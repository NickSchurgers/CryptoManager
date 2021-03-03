using System.Threading.Tasks;

namespace CryptoManager.Signals
{
    public interface ISignalAggregator
    {
        public void RegisterSignal(ISignal signal);

        public void WatchSignals();
    }
}
