using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selftest
{
    class TestClass
    {
        [Test]
        public void Mytest()
        {
            LoginPage loginpage = new LoginPage();
            loginpage.Nagavateurl();
            loginpage.loginToApplacation();
            loginpage.Ddltest();
            loginpage.logoff();

            //HomePage homePage = new HomePage();
            //homePage.logoff();

            //loginpage.Close();

            //string loginPageTitle = loginpage.GetTitle();
            // Assert.AreEqual("Mylogin.html", loginPageTitle, "Not on Login Page");
        }
    }
}
