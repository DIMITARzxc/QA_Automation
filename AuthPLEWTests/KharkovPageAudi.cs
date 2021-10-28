using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPLEWTests
{
    public class KharkovPageAudi
    {
        Driver _driver;
        public KharkovPageAudi(Driver driver)
        {
            _driver = driver;
        }
        private List<IWebElement> DivElements => _driver._driver.FindElements(
            By.CssSelector("div[class='head-ticket']")).ToList();
        public void AudiQ8Test()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.
                Assert.AreEqual(
                DivElements.First().Text.Substring(0, "Audi Q8".Length),
                "Audi Q8");
        }
    }
}
