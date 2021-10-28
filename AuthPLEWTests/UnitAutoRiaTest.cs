using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace AuthPLEWTests
{
    public class UnitAutoRiaTest
    {
        MainPageRia _main;
        KharkovPageAudi __kharkovAudi;
        Driver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new Driver();
            _main = new MainPageRia(_driver);
            __kharkovAudi = new KharkovPageAudi(_driver);
        }
        [Test]
        public void Test()
        {
            _main.Region();
            _main.Brand();
            _main.Model();
            _main.FindAuto();
            //----------------------
            __kharkovAudi.AudiQ8Test();
        }
        [TearDown]
        public void TearDown()
        {

        }
    }
}
