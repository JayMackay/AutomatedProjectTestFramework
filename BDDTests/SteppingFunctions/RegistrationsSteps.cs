using System;
using NUnit.Framework;
using AutomationProjectTestFramework.lib;
using TechTalk.SpecFlow;

namespace AutomationProjectTestFramework.BDDTests
{
    [Binding]
    public class RegistrationSteps
    {
        private AutomationProjectWebsite _automation;
        [Given(@"I am on the signup page")]
        public void GivenIAmOnTheSignupPage()
        {
            _automation = new AutomationProjectWebsite("chrome");
            _automation.AutomationProjectRegisterPage.GotoRegistrationPage();
        }

        [Given(@"I have enter a valid username of ""(.*)""")]
        public void GivenIHaveEnterAValidUsernameOf(string email)
        {
            _automation.AutomationProjectRegisterPage.InputEmail(email);
        }

        [When(@"i click off")]
        public void WhenIClickOff()
        {
            //behavior done be default
        }

        [Then(@"the result should see a green check mark in the box")]
        public void ThenTheResultShouldSeeAGreenCheckMarkInTheBox()
        {
            Assert.AreEqual(true, _automation.AutomationProjectRegisterPage.GoodEmailInput());
        }
    }
}