using System;
using NUnit.Framework;
using AutomationProjectTestFramework.lib;
using TechTalk.SpecFlow;
using System.Configuration;

namespace AutomationProjectTestFramework.BDD.SteppingFunctions
{
    [Binding]
    public class PaymentMethodSteps
    {
        private AutomatedProjectWebsite _automation;
        [Given(@"I am on the payment method page")]
        public void GivenIAmOnThePaymentMethodPage()
        {
            _automation = new AutomatedProjectWebsite("chrome");
            _automation.AutomationProjectHome.VisitHomePage();
            _automation.AutomationProjectHome.ClickSignInLink();
            _automation.AutomationProjectSignIn.EnterValidEmail("mitclork@mitclork.com");
            _automation.AutomationProjectSignIn.EnterValidPassword("mitclork");
            _automation.AutomationProjectMyAccount.SearchProduct("dress");
            _automation.AutomationProjectDress.AddProduct();
            _automation.AutomationProjectDress.ProceedToCart();
            _automation.AutomationProjectShoppingCart.ClickProceedToCheckOutLink();
            _automation.AutomationProjectAddress.ClickProceedToCheckout();
            _automation.AutomationProjectShipping.ClickProceedToCheckOutLink();
        }
        
        [When(@"I press Pay By Bank Wire")]
        public void WhenIPressPayByBankWire()
        {
            _automation.AutomationProjectPaymentMethod.PayByBankWire();
        }
        
        [Then(@"I should be on the Order Summary page")]
        public void ThenIShouldBeOnTheOrderSummaryPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
