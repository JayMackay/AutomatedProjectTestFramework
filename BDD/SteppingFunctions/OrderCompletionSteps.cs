using System;
using NUnit.Framework;
using AutomationProjectTestFramework.lib;
using TechTalk.SpecFlow;
using System.Configuration;
using System.Threading;

namespace AutomationProjectTestFramework
{
    [Binding]
    public class OrderCompletionSteps
    {
        private AutomatedProjectWebsite _automation;
        [Given(@"I am on the Order Summary Page")]
        public void GivenIAmOnTheOrderSummaryPage()
        {
            _automation = new AutomatedProjectWebsite("chrome");
            _automation.AutomationProjectHome.VisitHomePage();
            _automation.AutomationProjectHome.ClickSignInLink();
            _automation.AutomationProjectSignIn.EnterValidEmail("mitclork@mitclork.com");
            _automation.AutomationProjectSignIn.EnterValidPassword("mitclork");
            _automation.AutomationProjectSignIn.ConfirmationButton();
            Thread.Sleep(5000);
            _automation.AutomationProjectMyAccount.SearchProduct("dress");
            _automation.AutomationProjectDress.AddProduct();
            _automation.AutomationProjectDress.ProceedToCart();
            _automation.AutomationProjectShoppingCart.ClickProceedToCheckOutLink();
            _automation.AutomationProjectAddress.ClickProceedToCheckout();
            _automation.AutomationProjectShipping.ConfirmTermsOfService();
            _automation.AutomationProjectShipping.ClickProceedToCheckOutLink();
            _automation.AutomationProjectPaymentMethod.PayByBankWire();

        }

        [When(@"I press I Confirm My Order")]
        public void WhenIPressIConfirmMyOrder()
        {
            _automation.AutomationProjectOrderSummary.ClickConfirmOrder();
        }

        [Then(@"I am redirected to the Order Confirmation Page")]
        public void ThenIAmRedirectedToTheOrderConfirmationPage()
        {
            Assert.That(_automation.automationProjectConfirmation.ConfirmOrderConfirmationMessage,
                Is.EqualTo("Your order on My Store is complete."));

        }
        [AfterScenario()]
        public void DisposeWebDriver()
        {
            _automation.seleniumDriver.Dispose();
        }
    }
}