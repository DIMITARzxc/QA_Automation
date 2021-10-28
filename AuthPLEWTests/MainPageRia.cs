using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthPLEWTests
{
    public class MainPageRia
    {
        Driver _driver;
        public MainPageRia(Driver driver)
        {
            _driver = driver;
        }
        private IWebElement RegionForm => _driver._driver.FindElement(
            By.CssSelector("label[for='brandTooltipBrandAutocompleteInput-region']"));
        private IWebElement BrandForm => _driver._driver.FindElement(
            By.CssSelector("label[for='brandTooltipBrandAutocompleteInput-brand']"));
        private IWebElement ModelForm => _driver._driver.FindElement(
            By.CssSelector("label[for='brandTooltipBrandAutocompleteInput-model']"));
        private List<IWebElement> FormAElements => _driver._driver.FindElements(
            By.CssSelector("ul[class='unstyle scrollbar autocomplete-select'] > li > a")).ToList();
        private List<IWebElement> FormButtonElements => _driver._driver.FindElements(
    By.CssSelector("button")).ToList();
        public void Region()
        {
            RegionForm.Click();
            FormAElements.Where(a => a.Text.Contains("Харків"))
                .First().Click();
        }
        public void Brand()
        {
            BrandForm.Click();
            FormAElements.Where(a => a.Text.Contains("Audi"))
                .First().Click();
        }
        public void Model()
        {
            ModelForm.Click();
            FormAElements.Where(a => a.Text.Contains("Q8")).First().Click();
        }
        public void FindAuto()
        {
            FormButtonElements.Where(b => b.Text.Trim(' ').Contains("Пошук"))
                .First().Click();
        }
    }
}
