using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace AutomationProjectTestFramework.lib.driver_config
{
    class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(string driverName, int pageLoadWaitInSecs, int implicitWaitTimeInSecs)
        {
            DriverSetUp(driverName, pageLoadWaitInSecs, implicitWaitTimeInSecs);
        }

        private void DriverSetUp(string driverName, int pageLoadWaitInSecs, int implicitWaitTimeInSecs)
        {
            if (driverName.ToLower() == "chrome")
            {
                SetChromeDriver();
                SetDriverConfiguration(pageLoadWaitInSecs, implicitWaitTimeInSecs);
            }
            else if (driverName.ToLower() == "firefox")
            {
                SetFirefoxDriver();
                SetDriverConfiguration(pageLoadWaitInSecs, implicitWaitTimeInSecs);
            }
            else
            {
                throw new Exception("Please use 'chrome' or 'firefox' as the driver argument");
            }
        }
        public void SetChromeDriver()
        {
            Driver = new ChromeDriver();
        }

        private void SetFirefoxDriver()
        {
            Driver = new FirefoxDriver();
        }

        public void SetDriverConfiguration(int pageLoadWaitInSecs, int implicitWaitTimeInSecs)
        {
            //The is the time the driver will wait for the page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadWaitInSecs);
            //This is the time the driver waits for element before the test fails
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitTimeInSecs);
        }
    }
}
