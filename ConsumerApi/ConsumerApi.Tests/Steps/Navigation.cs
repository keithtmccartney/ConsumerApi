using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ConsumerApi.Tests.SupportFiles;

namespace ConsumerApi.Tests.Steps
{
    [Binding]
    public class Navigation
    {
        [Given(@"I have navigated to the Controller...")]
        public void NavigateToController()
        {
            PropertiesCollection.driver.Navigate().GoToUrl("");
        }

        [When(@"I see...")]
        public void Def()
        {
        }

        [Then(@"I should...")]
        public void Ghi()
        {
        }
    }
}