namespace CryptoManager.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Exchange : IModel
    {
        public Guid Id { get; set; }

        public Exchange Type { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
