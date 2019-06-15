using NUnit.Framework;
using OpenQA.Selenium;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearScore.ClearScorePages
{
    public class ClearScoreHomePage : BaseClass
    {

        private IWebElement logo;
        private IWebElement login;

        public void AndIAmOnHomePage()
        {
            logo = GetElementByCssSelector(".navbar-logos .logo.navbar-logo");
            Assert.True(logo.Displayed, "not displayed");

        }

        public ClearScoreLoginPage AndIClickLoginButton()
        {
            login = GetElementById("header-cta-btn--login");
            login.Click();

            return new ClearScoreLoginPage();
        }
    }
}
