using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectTestFramework.lib.pages
{
    class AutomationProjectShippingPage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;

        //PROCEED TO CHECK OUT NAVIGATION
        private IWebElement ProceedTocheckoutButton => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?controller=order&amp;step=1"));

        //CONTINUE SHOPPING NAVIGATION
        private IWebElement ContinueShoppingButton => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php"));

        //AGREE TERMS OF SERVICE
        private IWebElement TermsOfServiceCheckBox => this._driver.FindElement(By.Id("cgv"));

        public AutomationProjectShippingPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(_homePageUrl);
        }

        public void ClickProceedToCheckOutLink()
        {
            ProceedTocheckoutButton.Click();
        }
    }
}
