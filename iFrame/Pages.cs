using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFrame
{
    class Pages
    {
        IWebDriver driver;

        public Pages()
        {
            driver = new ChromeDriver();
        }

        public bool Resualt()
        {
            driver.Navigate().GoToUrl("https://designstreet.az/?gclid=EAIaIQobChMIgom5jpmf6gIVS7DtCh37kgQDEAEYASAAEgIMm_D_BwE");

            if (driver.FindElements(By.XPath("//*[text()='XİDMƏTLƏR']")).Count != 1)
            {
                driver.Quit();
                return false;

            }
            else
            {
                driver.Quit();
                return true;
            }

        }
        public bool Resualt2()
        {
            driver.Navigate().GoToUrl("https://e.dashamail.ru/?utm_source=google_adwords&utm_medium=cpc&utm_campaign=konkurenti&utm_content=46475941621&keyword=%2Bgetresponse|b&gclid=EAIaIQobChMIsNfXl6Gf6gIVlZ3VCh37cAAOEAEYAiAAEgI5qvD_BwE");

            if (driver.FindElements(By.XPath("//*[text()='Возможности DashaMail']")).Count != 1)
            {
                driver.Quit();
                return false;

            }
            else
            {
                driver.Quit();
                return true;
            }

        }

    }
}
