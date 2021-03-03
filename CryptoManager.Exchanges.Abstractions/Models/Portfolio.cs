using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CryptoManager.Exchanges.Models
{
    public class Portfolio
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Name { get; }

        public ICollection<Asset> Assets { get; } = new Collection<Asset>();

        public decimal Balance => Assets.Sum(x => x.TotalValue);

        public Portfolio(string name, IEnumerable<Asset> assets)
        {
            Name = name;

            foreach (Asset asset in assets)
            {
                Assets.Add(asset);
            }
        }
    }
}
