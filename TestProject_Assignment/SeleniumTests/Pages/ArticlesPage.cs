using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProject_Assignment.SeleniumTests.Pages
{
    
    public class ArticlesPage : BasePage
    {
        public ArticlesPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        private IWebElement homepageLogo => driver.FindElement(By.XPath("//*[@src=\"./assets/images/SOliver-Logo.svg\"]"));
        private IWebElement article => driver.FindElement(By.XPath("//*[@id=\"app\"]/div[contains(@class, \"product-page\")]/div[contains(@class, \"product-page__card\")][1]"));


        public bool IsArticlePresent()
        {
            if (article.Displayed)
                return true;
            else
                return false;
            
        }

        public bool IsHomepageLogoPresent()
        {
            if (homepageLogo.Displayed)
                return true;
            else
                return false;

        }



    }
}
