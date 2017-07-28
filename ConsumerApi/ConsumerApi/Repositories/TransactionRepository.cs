using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using ConsumerApi.Interfaces;
using ConsumerApi.Models;

namespace ConsumerApi.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly TransactionContext _context;

        public TransactionRepository(TransactionContext context)
        {
            _context = context;
        }

        public Transaction Add(Transaction transaction)
        {
            var _transaction = _context.Transactions.Add(new Transaction() { TransactionId = transaction.TransactionId });

            _context.SaveChanges();

            return transaction;
        }

        public void Delete(Transaction transaction)
        {
            _context.Transactions.Remove(transaction);
            _context.SaveChanges();
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _context.Transactions.ToList();
        }

        public Transaction GetById(int id)
        {
            return _context.Transactions.SingleOrDefault(x => x.TransactionId == id);
        }

        public void Update(Transaction transaction)
        {
            var _transaction = GetById(transaction.TransactionId);

            _transaction.TransactionDate = transaction.TransactionDate;
            _transaction.TransactionAmount = transaction.TransactionAmount;
            _transaction.CreatedDate = transaction.CreatedDate;
            _transaction.ModifiedDate = transaction.ModifiedDate;
            _transaction.CurrencyCode = transaction.CurrencyCode;

            _context.Entry(_transaction).CurrentValues.SetValues(transaction);
            _context.SaveChanges();
        }
    }
}