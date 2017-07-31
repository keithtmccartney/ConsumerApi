using System;
using System.Collections.Generic;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ConsumerApi.Controllers;
using ConsumerApi.Interfaces;
using ConsumerApi.Models;

namespace ConsumerApi.Tests
{
    [TestClass]
    public class Navigation
    {
        private readonly ITransactionRepository _transactionRepository;

        [TestMethod]
        public void GetAll_ShouldReturnAllTransactions()
        {
            IWebDriver driver;

            ChromeOptions profile = new ChromeOptions();

            profile.AddArgument("start-maximized");
            profile.AddArgument("--disable-extensions");

            var testTransactions = GetTestTransactions();

            /*var controller = new TransactionController(testTransactions);

            var result = controller.GetTransactions() as List<Transaction>;
            Assert.AreEqual(testTransactions.Count, result.Count);*/

            driver = new ChromeDriver(profile);

            driver.Navigate().GoToUrl("http://localhost:50908/transaction");
        }

        [TestMethod]
        public void GetById_ShouldReturnCorrectTransaction()
        {
            /*var controller = new TransactionController(GetTestTransactions());

            var result = controller.GetTransaction(999);

            Assert.IsInstanceOfType(result, typeof(NotFoundResult));*/

        }

        [TestMethod]
        public void Update_ShouldUpdateCorrectTransaction()
        {
        }

        [TestMethod]
        public void Add_ShouldAddCorrectTransaction()
        {
        }

        [TestMethod]
        public void Delete_ShouldDeleteCorrectTransaction()
        {
        }

        [TestMethod]
        public void GetById_ShouldNotFindTransaction()
        {
            /*var controller = new TransactionController(GetTestTransactions());

            var result = controller.GetTransaction(999);

            Assert.IsInstanceOfType(result, typeof(NotFoundResult));*/
        }

        private List<Transaction> GetTestTransactions()
        {
            var testTransactions = new List<Transaction>();

            testTransactions.Add(new Transaction { TransactionId = 1, TransactionDate = DateTime.Now, Description = "'Suppy yuppy yo'!", TransactionAmount = 123, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, CurrencyCode = "Abc", Merchant = "Def ghi 456" });
            testTransactions.Add(new Transaction { TransactionId = 2, TransactionDate = DateTime.Now, Description = "'Suppy yuppy yo'!", TransactionAmount = 456, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, CurrencyCode = "Def", Merchant = "Def ghi 456" });
            testTransactions.Add(new Transaction { TransactionId = 3, TransactionDate = DateTime.Now, Description = "'Suppy yuppy yo'!", TransactionAmount = 789, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, CurrencyCode = "Ghi", Merchant = "Def ghi 456" });

            return testTransactions;
        }
    }
}