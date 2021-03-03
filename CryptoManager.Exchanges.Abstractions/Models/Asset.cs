namespace CryptoManager.Exchanges.Models
{
    public class Asset
    {
        public string Name { get; }

        public decimal Amount { get; }

        public decimal Value { get; }

        public decimal TotalValue => Amount * Value;

        public Asset(string name, decimal amount, decimal value)
        {
            Name = name;
            Amount = amount;
            Value = value;
        }
    }
}
