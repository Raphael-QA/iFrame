using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFrame
{
    class Test
    {
        Pages pages = new Pages();
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://someurl.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
        }
        [Test]
        public void TestFirst()
        {
            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@id='master-1']"));
            driver.SwitchTo().Frame(frame1);

            driver.FindElement(By.XPath("//div[@class='da_']//span[text() = 'Internet URL']/..")).Click();

            IWebElement frame2 = driver.FindElement(By.XPath("//iframe[@id='master-1']"));
            driver.SwitchTo().Frame(frame2);

            driver.FindElement(By.XPath("//*[@id='e2']/div[3]/div/div/a")).Click();

            Assert.IsTrue(pages.Resualt());
            driver.Quit();
        }
        
            [Test]
        public void TestSecond()
        {
            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@id='master-1']"));
            driver.SwitchTo().Frame(frame1);

            driver.FindElement(By.XPath("//div[@class='da_']//span[text() = 'Get Response']/..")).Click();

            IWebElement frame2 = driver.FindElement(By.XPath("//iframe[@id='master-1']"));
            driver.SwitchTo().Frame(frame2);

            driver.FindElement(By.XPath("//*[@id='e2']/div[4]/div/div/a/span")).Click();

            Assert.IsTrue(pages.Resualt2());
            driver.Quit();
        }



    }
}
