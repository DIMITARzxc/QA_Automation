using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace AuthPLEWTests
{
    public class UnitAutoRiaTest
    {
        IWebDriver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            _driver.Navigate().GoToUrl("https://auto.ria.com/");

        }
        [Test]
        public void Test()
        {
            GetElement("label[for='brandTooltipBrandAutocompleteInput-region']")
                .Click();
            GetElements("ul[class='unstyle scrollbar autocomplete-select'] > li > a")
                .Where(a => a.Text.Contains("Харків")).First().Click();
            GetElement("label[for='brandTooltipBrandAutocompleteInput-brand']")
                .Click();
            GetElements("ul[class='unstyle scrollbar autocomplete-select'] > li > a")
                .Where(a => a.Text.Contains("Audi")).First().Click();
            GetElement("label[for='brandTooltipBrandAutocompleteInput-model']")
                .Click();
            GetElements("ul[class='unstyle scrollbar autocomplete-select'] > li > a")
                .Where(a => a.Text.Contains("Q8")).First().Click();
            GetElements("button")
                .Where(b => b.Text.Trim(' ').Contains("Пошук"))
                .First().Click();
            var elementDivText = GetElements("div[class='head-ticket']")
                .First().Text;
            Microsoft.VisualStudio.TestTools.UnitTesting.
                Assert.AreEqual(
                elementDivText.Substring(0, "Audi Q8".Length), 
                "Audi Q8");
        }
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
        private IWebElement GetElement(string css)
        {
            return _driver.FindElement(By.CssSelector(css));
        }
        private List<IWebElement> GetElements(string css)
        {
            return _driver.FindElements(By.CssSelector(css))
                .ToList();
        }
    }
}
