using System;

namespace CryptoManager.Data.Models
{
    public class Asset : IModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }

        public decimal Value { get; set; }
    }
}
