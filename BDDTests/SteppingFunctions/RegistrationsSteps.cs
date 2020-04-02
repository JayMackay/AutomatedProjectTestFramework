using System;
using NUnit.Framework;
using AutomationProjectTestFramework.lib;
using TechTalk.SpecFlow;

namespace AutomationProjectTestFramework.BDDTests
{
    [Binding]
    public class RegistrationSteps
    {
        private AutomatedProjectWebsite _automation;
        [Given(@"I am on the signup page")]
        public void GivenIAmOnTheSignupPage()
        {
            _automation = new AutomatedProjectWebsite("chrome");
            _automation.AutomationProjectHomePage.GotoRegistrationPage();
        }

        [Given(@"I have enter a valid username of ""(.*)""")]
        public void GivenIHaveEnterAValidUsernameOf(string email)
        {
            _automation.AutomationProjectHomePage.InputEmail(email);
        }

        [When(@"i click off")]
        public void WhenIClickOff()
        {
            _automation.AutomationProjectHomePage.Clickoff();
        }

        [Then(@"the result should see a green check mark in the box")]
        public void ThenTheResultShouldSeeAGreenCheckMarkInTheBox()
        {
            Assert.AreEqual(true, _automation.AutomationProjectHomePage.GoodEmailInput());
        }

        [AfterScenario()]
        public void DisposeWebDriver()
        {
            _automation.seleniumDriver.Dispose();
            _automation.seleniumDriver.Quit();
        }
    }
}