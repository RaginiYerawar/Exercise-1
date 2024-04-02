using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace TestProject_Assignment.SeleniumTests.Utilities
{
    internal class WebdriverFactory
    {
        public static IWebDriver GetDriver()
        {
            // Customise this method to support different browsers, configurations, etc.
            return new ChromeDriver();
        }

        
    }
}
