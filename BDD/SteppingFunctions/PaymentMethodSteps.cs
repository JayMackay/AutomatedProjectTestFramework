using System;
using TechTalk.SpecFlow;

namespace AutomationProjectTestFramework.BDDTests.SteppingFunctions
{
    [Binding]
    public class PaymentMethodSteps
    {
        [Given(@"I am on the payment method page")]
        public void GivenIAmOnThePaymentMethodPage()
        {
            
        }
        
        [When(@"I press Pay By Bank Wire")]
        public void WhenIPressPayByBankWire()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be on the Order Summary page")]
        public void ThenIShouldBeOnTheOrderSummaryPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
