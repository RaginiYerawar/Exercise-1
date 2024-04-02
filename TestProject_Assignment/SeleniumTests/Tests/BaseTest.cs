using NUnit.Framework;
using TestProject_Assignment.SeleniumTests.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace TestProject_Assignment.SeleniumTests.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();

            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            // Navigate to the s.Oliver E-Shop website
            driver.Navigate().GoToUrl("http://localhost:8080/");
            Thread.Sleep(7000);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
