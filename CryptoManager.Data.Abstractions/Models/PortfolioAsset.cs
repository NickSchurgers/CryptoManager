namespace CryptoManager.Data.Models
{
    using System;

    public class PortfolioAsset : IModel
    {
        public Guid Id { get; set; }

        public decimal Amount { get; set; }

        public decimal Value { get; set; }

        public Guid PortfolioId { get; set; }

        public Portfolio Portfolio { get; set; }

        public Guid AssetId { get; set; }

        public Asset Asset { get; set; }
    }
}
