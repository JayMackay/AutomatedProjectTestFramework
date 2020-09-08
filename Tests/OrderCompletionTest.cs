using AutomationProjectTestFramework.lib;
using NUnit.Framework;

namespace AutomationProjectTestFramework.Tests
{
    [TestFixture]
    public class OrderCompletionTest
    {
        //Instantiate the page objects, include all functionality for the web pages
        public AutomatedProjectWebsite AutomatedProjectWebsite;

        [Test]
        public void OrderCompletionTestFullPath()
        {
            //Set up driver & page model
            AutomatedProjectWebsite = new AutomatedProjectWebsite("chrome");

            //Order steps
            AutomatedProjectWebsite.AutomationProjectHome.VisitHomePage();
            AutomatedProjectWebsite.AutomationProjectHome.ClickSignInLink();
            AutomatedProjectWebsite.AutomationProjectSignIn.EnterValidEmail("user.testing@gmail.com");
            AutomatedProjectWebsite.AutomationProjectSignIn.EnterValidPassword("Admin");
            AutomatedProjectWebsite.AutomationProjectSignIn.ConfirmationButton();
            AutomatedProjectWebsite.AutomationProjectMyAccount.SearchProduct("dress");
            AutomatedProjectWebsite.AutomationProjectDress.AddProduct();
            AutomatedProjectWebsite.AutomationProjectDress.ProceedToCart();
            AutomatedProjectWebsite.AutomationProjectShoppingCart.ClickProceedToCheckOutLink();
            AutomatedProjectWebsite.AutomationProjectAddress.ClickProceedToCheckout();
            AutomatedProjectWebsite.AutomationProjectShipping.ConfirmTermsOfService();
            AutomatedProjectWebsite.AutomationProjectShipping.ClickProceedToCheckOutLink();
            AutomatedProjectWebsite.AutomationProjectPaymentMethod.PayByBankWire();
            AutomatedProjectWebsite.AutomationProjectOrderSummary.ClickConfirmOrder();

            Assert.That(AutomatedProjectWebsite.AutomationProjectConfirmation.ConfirmOrderConfirmationMessage,
                Is.EqualTo("Your order on My Store is complete."));
        }
    }
}
