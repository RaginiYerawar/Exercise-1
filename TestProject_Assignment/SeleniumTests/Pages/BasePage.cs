using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Assignment.SeleniumTests.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        public BasePage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                // Attempt to find the element
                var element = wait.Until(c => c.FindElement(by));

                return true;
            }
            catch (WebDriverTimeoutException)
            {
                //Console.WriteLine("Element was not found within the specified timeout")
                // Element was not found within the specified timeout
                return false;
            }
        }
    }
}
