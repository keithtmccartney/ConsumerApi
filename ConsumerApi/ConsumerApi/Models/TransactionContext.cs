using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsumerApi.Models
{
    public class TransactionContext : List<Transaction>
    {
        public List<Transaction> Transactions = new List<Transaction>();
    }
}