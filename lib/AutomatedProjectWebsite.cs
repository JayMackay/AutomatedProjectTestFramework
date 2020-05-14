using AutomationProjectTestFramework.lib.driver_config;
using AutomationProjectTestFramework.lib.pages;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib
{
    //Service object for all website pages
    public class AutomatedProjectWebsite
    {
        //Accessible read only page objects
        public readonly AutomationProjectHomePage AutomationProjectHome;
        public readonly AutomationProjectShoppingCartPage AutomationProjectShoppingCart;
        public readonly AutomationProjectRegisterPage AutomationProjectRegister;
        public readonly AutomationProjectAddressPage AutomationProjectAddress;
        public readonly AutomationProjectDressPage AutomationProjectDress;
        public readonly AutomationProjectMyAccountPage AutomationProjectMyAccount;
        public readonly AutomationProjectOrderSummaryPage AutomationProjectOrderSummary;
        public readonly AutomationProjectSignInPage AutomationProjectSignIn;
        public readonly AutomationProjectPaymentMethodPage AutomationProjectPaymentMethod;
        public readonly AutomationProjectShippingPage AutomationProjectShipping;
        public readonly AutomationProjectConfirmationPage AutomationProjectConfirmation;
        public readonly IWebDriver seleniumDriver;


        //Constructor for driver and config for the service
        public AutomatedProjectWebsite(string drivername, int pageLoadWaitInSecs = 10, int implicitWaitTimeInSecs = 10)
        {
            //Instantiation of driver
            seleniumDriver = new SeleniumDriverConfig(drivername, pageLoadWaitInSecs, implicitWaitTimeInSecs).Driver;

            //Instantiation of page objects with the selenium driver
            AutomationProjectHome = new AutomationProjectHomePage(seleniumDriver);
            AutomationProjectShoppingCart = new AutomationProjectShoppingCartPage(seleniumDriver);
            AutomationProjectRegister = new AutomationProjectRegisterPage(seleniumDriver);
            AutomationProjectAddress = new AutomationProjectAddressPage(seleniumDriver);
            AutomationProjectDress = new AutomationProjectDressPage(seleniumDriver);
            AutomationProjectMyAccount = new AutomationProjectMyAccountPage(seleniumDriver);
            AutomationProjectOrderSummary = new AutomationProjectOrderSummaryPage(seleniumDriver);
            AutomationProjectRegister = new AutomationProjectRegisterPage(seleniumDriver);
            AutomationProjectSignIn = new AutomationProjectSignInPage(seleniumDriver);
            AutomationProjectPaymentMethod = new AutomationProjectPaymentMethodPage(seleniumDriver);
            AutomationProjectShipping = new AutomationProjectShippingPage(seleniumDriver);
            AutomationProjectConfirmation = new AutomationProjectConfirmationPage(seleniumDriver);
        }
    }

}
