namespace CryptoManager.Exchanges.Models
{
    public record Asset
    {
        public string Name { get; init; }

        public decimal Amount { get; init; }

        public decimal Value { get; init; }

        public decimal TotalValue => Amount * Value;
    }
}
