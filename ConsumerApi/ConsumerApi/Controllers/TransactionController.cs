﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ConsumerApi.Interfaces;
using ConsumerApi.Models;

namespace ConsumerApi.Controllers
{
    public class TransactionController : ApiController
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly Models.TransactionContext _context;

        public TransactionController(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        /*List<Transaction> _context = new List<Transaction>();*/

        /*public TransactionController()
        {
        }

        public TransactionController(List<Transaction> _transaction)
        {
            this._context = _transaction;
        }*/

        // GET: /transaction/get
        [HttpGet]
        [Route("transaction/get", Name = "GetAllTransactions")]
        public IEnumerable<Transaction> GetTransactions()
        {
            return _transactionRepository.GetAll();

            /*return _context;*/
        }

        // GET: /transaction/get/5
        [HttpGet]
        [Route("transaction/get/{id}", Name = "GetTransactionByID")]
        [ResponseType(typeof(Transaction))]
        public IHttpActionResult GetTransaction(int id)
        {
            var _transaction = _transactionRepository.GetById(id);

            /*var _transaction = _context.FirstOrDefault((p) => p.TransactionId == id);*/

            if (_transaction == null)
            {
                return NotFound();
            }

            return Ok(_transaction);
        }

        // PUT: /transaction/put/5
        [HttpPut]
        [Route("transaction/put/{id}", Name = "PutTransactionByID")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTransaction(int id, Transaction _parameter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _parameter.TransactionId = id;

                _transactionRepository.Update(_parameter);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: /transaction/post
        [HttpPost]
        [Route("transaction/post", Name = "PostAllTransactions")]
        [ResponseType(typeof(Transaction))]
        public IHttpActionResult PostTransaction(Transaction _parameter)
        {
            if (_parameter == null)
            {
                return BadRequest(ModelState);
            }

            var _transaction = _transactionRepository.Add(_parameter);

            return CreatedAtRoute("DefaultApi", new { controller = "transaction", id = _transaction.TransactionId }, _transaction);
        }

        // DELETE: /transaction/delete/5
        [HttpDelete]
        [Route("transaction/delete/{id}", Name = "DeleteTransactionByID")]
        [ResponseType(typeof(Transaction))]
        public IHttpActionResult DeleteTransaction(int id)
        {
            var _transaction = _transactionRepository.GetById(id);

            if (_transaction == null)
            {
                return NotFound();
            }

            _transactionRepository.Delete(_transaction);

            return Ok(_transaction);
        }

        private bool TransactionExists(int id)
        {
            return _context.Count(e => e.TransactionId == id) > 0;
        }
    }
}