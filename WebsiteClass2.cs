using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.IE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
namespace WebTestProject1
{
    public class WebsiteClass2
    {
        [TestMethod]
        public void TestMethod2_YorskhireWaters()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://facebook.com/");
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Hello");
            element.Submit();
        }
    }
}
