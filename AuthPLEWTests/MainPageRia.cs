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
        public void Region()// I suggest to make these methods more universal, could you pass a string as a parameter to search a city depending on passed param
        {
            RegionForm.Click();
            FormAElements.Where(a => a.Text.Contains("Харків"))// what is FormAElements, maybe you mean FormElements? 
                .First().Click();
        }
        public void Brand()// what is brand()? please give a more understandable method name for example => SelectBrand. the same for the all methods; 
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
