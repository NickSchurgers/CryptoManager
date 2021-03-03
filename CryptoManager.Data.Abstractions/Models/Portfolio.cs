using System;
using System.Collections.Generic;

namespace CryptoManager.Data.Models
{
    public class Portfolio : IModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Asset> Assets { get; set; }
    }
}
