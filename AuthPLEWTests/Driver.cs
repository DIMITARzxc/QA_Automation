using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPLEWTests
{
    public class Driver
    {
        public IWebDriver _driver;

        public Driver()
        {
            _driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            _driver.Navigate().GoToUrl("https://auto.ria.com/");
        }
        public void Quit()
        {
            if (_driver != null)
                _driver.Quit();
        }
    }
}
