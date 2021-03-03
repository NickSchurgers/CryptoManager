using System;

namespace CryptoManager.Signals
{
    public class SignalReceivedEventArgs : EventArgs
    {
        public SignalType SignalType { get; }

        public int Weight { get; }

        public SignalReceivedEventArgs(SignalType type, int weight)
        {
            SignalType = type;
            Weight = weight;
        }
    }
}
