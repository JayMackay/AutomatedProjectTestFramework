using AutomationProjectTestFramework.lib.driver_config;
using AutomationProjectTestFramework.lib.pages;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib
{
    //Service object for all website pages
    public class AutomatedProjectWebsite
    {
        //Accessible read only page objects


        public readonly AutomationProjectHomePage AutomationProjectHomePage;
        public readonly AutomationProjectShoppingCartPage AutomationProjectShoppingCartPage;
        public readonly AutomationProjectRegisterPage AutomationProjectRegisterPage;
        public readonly AutomationProjectAddressPage AutomationProjectAddressPage;
        public readonly AutomationProjectDressPage AutomationProjectDressPage;
        public readonly AutomationProjectMyAccountPage AutomationProjectMyAccountPage;
        public readonly AutomationProjectOrderSummaryPage AutomationProjectOrderSummaryPage;
        public readonly AutomationProjectSignInPage AutomationProjectSignInPage;
        public readonly AutomationProjectPaymentMethod AutomationProjectPaymentMethod;
        public readonly AutomationProjectShippingPage AutomationProjectShippingPage;
        public readonly IWebDriver seleniumDriver;

        //Constructor for driver and config for the service
        public AutomatedProjectWebsite(string drivername, int pageLoadWaitInSecs = 10, int implicitWaitTimeInSecs = 10)
        {
            //Instantiation of driver
            seleniumDriver = new SeleniumDriverConfig(drivername, pageLoadWaitInSecs, implicitWaitTimeInSecs).Driver;

            //Instantiation of page objects with the selenium driver

            AutomationProjectHomePage = new AutomationProjectHomePage(seleniumDriver);
            AutomationProjectShoppingCartPage = new AutomationProjectShoppingCartPage(seleniumDriver);
            AutomationProjectRegisterPage = new AutomationProjectRegisterPage(seleniumDriver);
            AutomationProjectAddressPage = new AutomationProjectAddressPage(seleniumDriver);
            AutomationProjectDressPage = new AutomationProjectDressPage(seleniumDriver);
            AutomationProjectMyAccountPage = new AutomationProjectMyAccountPage(seleniumDriver);
            AutomationProjectOrderSummaryPage = new AutomationProjectOrderSummaryPage(seleniumDriver);
            AutomationProjectRegisterPage = new AutomationProjectRegisterPage(seleniumDriver);
            AutomationProjectSignInPage = new AutomationProjectSignInPage(seleniumDriver);
            AutomationProjectPaymentMethod = new AutomationProjectPaymentMethod(seleniumDriver);
            AutomationProjectShippingPage = new AutomationProjectShippingPage(seleniumDriver);


        }
    }

}
