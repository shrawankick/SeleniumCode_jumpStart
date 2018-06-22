using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Selftest
{
    public class LoginPage
    {
        IWebDriver driver = new ChromeDriver();
        

        //IWebDriver driver;

        /// <summary>
        /// url 
        ///   IWebDriver driver;

        /// 
        /// </summary>
        public void Nagavateurl()
        {
            string url = "http://demo.guru99.com/V1/index.php";
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.UrlContains(""));
            //IWebElement element = driver.FindElement(By.XPath("//*[@name='uid']"));
            //wait.Until(driver, SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("")));
        }

        public void PageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10); //pageLoadTimeout(10, TimeUnit.SECONDS);
        }



        public void Login()
        {
            driver.FindElement(By.XPath("//*[@name='uid']")).SendKeys("mngr47659");
            driver.FindElement(By.XPath("//*[@name='password']")).SendKeys("12345@");
            driver.Manage().Window.Maximize();
        }

        public void loginToApplacation()
        {
            Login();
            driver.FindElement(By.XPath("//*[@name='btnLogin']")).Click();

        }

        public void Ddltest()
        {

            IWebElement element = driver.FindElement(By.ClassName("menusubnav")).FindElement(By.XPath("//a[@href = 'addAccount.php']"));
            Javascriptclick(element);


            //Actions actions = new Actions(driver);
            //actions.MoveToElement(element).Click().Build().Perform();



            var ddlItem = driver.FindElement(By.XPath("//td/select"));
            var SelectItem = new SelectElement(ddlItem);
            SelectItem.SelectByText("current");

            //var ParentWind = driver.CurrentWindowHandle;
            ////Click
            //var newWinddow = driver.CurrentWindowHandle;

            //driver.SwitchTo().Window(newWinddow);
            //driver.Close();
            //driver.SwitchTo().Window(ParentWind);


        }

        private void Javascriptclick(IWebElement element)
        {
            IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
            javaScriptExecutor.ExecuteScript("arguments[0].click();", element);
        }

        public void logoff()
        {
            driver.FindElement(By.XPath("//div[3]/div/ul/li[10]")).Click();
            IAlert alert = driver.SwitchTo().Alert();
            var text = alert.Text;
            Console.WriteLine(text);
            alert.Accept();
        }

        

        [TearDown]
        public void Close()
        {
            driver.Close();
        }

    }


}
