using NUnit.Framework;
using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject_Assignment.SeleniumTests.Pages;
using System.Drawing.Imaging;

namespace TestProject_Assignment.SeleniumTests.Tests
{
    [TestFixture]
    public class ArticlesPageTest : BaseTest
    {
        private ArticlesPage articlesPage;

        [SetUp]
        public void SetUpArticlesPage()
        {
            articlesPage = new ArticlesPage(driver, wait);
        }


        [Test]
        public void VerifyIsHomepageLogoPresent()
        {
            Assert.IsTrue(articlesPage.IsHomepageLogoPresent(), "s. Oliver logo isn't present");

        }

        
    }
}
