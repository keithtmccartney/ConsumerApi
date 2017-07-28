using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsumerApi.Models
{
    public class TransactionContext : DbContext
    {
        public TransactionContext() : base("name=TransactionContext")
        {
        }

        public DbSet<Transaction> Transactions
        {
            get; set;
        }
    }
}