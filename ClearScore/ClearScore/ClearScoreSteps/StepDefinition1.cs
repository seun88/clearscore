using ClearScore.ClearScorePages;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ClearScore.ClearScoreSteps
{
    [Binding]
    public sealed class StepDefinition1
    {
        private ClearScoreHomePage homepage;
        private ClearScoreLoginPage loginpage;
        private ClearScoreMyAccountPage Myaccount;
        

        [Given(@"I Navigate to Homepage")]
        public void GivenINavigateToHomepage()
        {
            homepage = BaseClass.GivenINavigateToHomePage();
            homepage.AndIAmOnHomePage();
            loginpage = homepage.AndIClickLoginButton();


            
        }

        [When(@"I input valid credentials")]
        public void WhenIInputValidCredentials()
        {
            loginpage.AndInputemail();
            loginpage.AndInputPassword();
            Myaccount = loginpage.AndClickloginbutton();
            
        }


    }
}
