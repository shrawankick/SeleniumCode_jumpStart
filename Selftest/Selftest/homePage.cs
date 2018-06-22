using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selftest
{
    class HomePage 
    {
        IWebDriver driver = new ChromeDriver();

        public void logoff()

        {
            
            driver.FindElement(By.XPath("//div[3]/div/ul/li[10]")).Click();

        }
    }
}
