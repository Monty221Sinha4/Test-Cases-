using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
namespace SeoulAirport.TestCases
{
    [TestClass]
    public class Facebool
    {
        [TestMethod]
        public void TestSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http//www.facebook.com");
            IWebElement element = driver.FindElement(By.Name("Q"));
            element.SendKeys("Hello");
            element.Submit();
        }
    }
}