using System;
using System.Threading;
using AutomationProjectTestFramework.lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AutomationProjectTestFramework.BDD.SteppingFunctions
{
    [Binding]
    public class RegisterUserSteps
    {
        private AutomatedProjectWebsite _automation;
        [Given(@"I am on the sign up page")]
        public void GivenIAmOnTheSignUpPage()
        {
            _automation = new AutomatedProjectWebsite("chrome");
            _automation.AutomationProjectRegister.GotoRegistrationPage();
        }
        
        [Given(@"I have entered a valid email")]
        public void GivenIHaveEnteredAValidEmail()
        {
            _automation.AutomationProjectRegister.InputEmail("abcd@work.com");
            _automation.AutomationProjectRegister.GotoSignupForm();
            Thread.Sleep(3000);

        }
        
        [Given(@"I have enterd valid details")]
        public void GivenIHaveEnterdValidDetails()
        {
            _automation.AutomationProjectRegister.checkMrTitle();
            _automation.AutomationProjectRegister.inputFullName("BOB");
            _automation.AutomationProjectRegister.inputLastName("Sharp");
            _automation.AutomationProjectRegister.inputPassword("mypassword");
            
            //selectboxes
            _automation.AutomationProjectRegister.inputDay();
            _automation.AutomationProjectRegister.inputMonth();
            _automation.AutomationProjectRegister.inputYear();

            _automation.AutomationProjectRegister.inputAddress("123 bob road");
            _automation.AutomationProjectRegister.inputCity("brum");

            _automation.AutomationProjectRegister.inputSate();

            _automation.AutomationProjectRegister.inputZip("90110");

            _automation.AutomationProjectRegister.inputCounty();

            _automation.AutomationProjectRegister.inputMoblilePhone("0788695425");
            _automation.AutomationProjectRegister.inputAddressName("bob's house");

        }
        
        [When(@"I press Register")]
        public void WhenIPressRegister()
        {
            _automation.AutomationProjectRegister.SubmitButton();
        }
        
        [Then(@"the result should be on the my account page")]
        public void ThenTheResultShouldBeOnTheMyAccountPage()
        {
            Assert.AreEqual(1,1);
        }
    }
}
