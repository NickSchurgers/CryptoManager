﻿namespace CryptoManager.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Asset : IModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<PortfolioAsset> PortfolioAssets { get; set; }
    }
}
