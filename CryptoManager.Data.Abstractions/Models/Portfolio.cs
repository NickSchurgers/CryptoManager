namespace CryptoManager.Data.Models
{
    using CryptoManager.Trading;
    using System;
    using System.Collections.Generic;

    public class Portfolio : IModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public TradingStrategy Strategy { get; set; }

        public ICollection<PortfolioAsset> PortfolioAssets { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}
