using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumerApi.Models
{
    public class Transaction
    {
        public int TransactionId
        {
            get; set;
        }

        public DateTime TransactionDate
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public int TransactionAmount
        {
            get; set;
        }

        public DateTime CreatedDate
        {
            get; set;
        }

        public DateTime ModifiedDate
        {
            get; set;
        }

        public string CurrencyCode
        {
            get; set;
        }

        public string Merchant
        {
            get; set;
        }
    }
}