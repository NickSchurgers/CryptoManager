namespace CryptoManager.Data.Models
{
    using System;
    using System.Collections.Generic;
    using CryptoManager.Trading;

    public class Strategy : IModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public TradingStrategy TradingStrategy { get; set; }

        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
