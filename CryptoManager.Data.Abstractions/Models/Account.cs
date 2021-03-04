namespace CryptoManager.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Account : IModel
    {
        public Guid Id { get; set; }

        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
