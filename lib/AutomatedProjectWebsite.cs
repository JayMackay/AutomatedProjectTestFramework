using AutomationProjectTestFramework.lib.driver_config;
using AutomationProjectTestFramework.lib.pages;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib
{
    //Service object for all website pages
    public class AutomationProjectWebsite
    {
        //Accessible read only page objects
        public readonly AutomationProjectHomePage AutomationProjectHome;
        public readonly AutomationProjectShoppingCartPage AutomationProjectShoppingCart;
        public readonly AutomationProjectRegisterPage AutomationProjectRegisterPage;
        public readonly IWebDriver seleniumDriver;

        //Constructor for driver and config for the service
        public AutomationProjectWebsite(string drivername, int pageLoadWaitInSecs = 10, int implicitWaitTimeInSecs = 10)
        {
            //Instantiation of driver
            seleniumDriver = new SeleniumDriverConfig(drivername, pageLoadWaitInSecs, implicitWaitTimeInSecs).Driver;

            //Instantiation of page objects with the selenium driver
            AutomationProjectHome = new AutomationProjectHomePage(seleniumDriver);
            AutomationProjectShoppingCart = new AutomationProjectShoppingCartPage(seleniumDriver);
            AutomationProjectRegisterPage = new AutomationProjectRegisterPage(seleniumDriver);
        }
    }

}
