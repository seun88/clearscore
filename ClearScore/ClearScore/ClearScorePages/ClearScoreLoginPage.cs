using OpenQA.Selenium;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearScore.ClearScorePages
{
    public class ClearScoreLoginPage :BaseClass 
    {
        private IWebElement validemail;
        private IWebElement validpassword;
        private IWebElement clickloginbutton;

        public void AndInputemail()
        {
            validemail = GetElementById("loginform_email_input");
            validemail.SendKeys("seunakinbode@yahoo.com");
        }

        public void AndInputPassword()
        {
            validpassword = GetElementById("loginform_password_input");
            validpassword.SendKeys("Serah1988");
        }

        public ClearScoreMyAccountPage AndClickloginbutton()
        {
            clickloginbutton = GetElementByCssSelector(".base--2Z7Kb.button--26LBC.overlay--2AUiP");
            clickloginbutton.Click();

            return new ClearScoreMyAccountPage();
        }
    }
}
