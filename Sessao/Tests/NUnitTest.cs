using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Sessao.Tests
{
    public class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.google.com";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}