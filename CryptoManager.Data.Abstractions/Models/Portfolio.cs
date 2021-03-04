namespace CryptoManager.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Portfolio : IModel
    {
        public Guid Id { get; set; }

        public ICollection<PortfolioAsset> PortfolioAssets { get; set; }

        public string Name { get; set; }

        public Guid StrategyId { get; set; }

        public Strategy Strategy { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
    }
}
