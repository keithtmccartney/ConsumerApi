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
        private int counter = 1;

        public TransactionRepository(TransactionContext context)
        {
            _context = context;
        }

        public Transaction Add(Transaction _transaction)
        {
            if (_transaction == null)
                throw new ArgumentNullException("_transaction");

            _transaction.TransactionId = counter++;

            _context.Add(_transaction);

            return _transaction;
        }

        public void Delete(Transaction _transaction)
        {
            _context.Remove(_transaction);
        }

        public IEnumerable<Transaction> GetAll()
        {
            return _context.ToList();
        }

        public Transaction GetById(int id)
        {
            return _context.SingleOrDefault(x => x.TransactionId == id);
        }

        public void Update(Transaction _transaction)
        {
            int transaction = _context.FindIndex(b => b.TransactionId == _transaction.TransactionId);

            if (transaction != -1)
            {
                _context.RemoveAt(transaction);
                _context.Add(_transaction);
            }
        }
    }
}