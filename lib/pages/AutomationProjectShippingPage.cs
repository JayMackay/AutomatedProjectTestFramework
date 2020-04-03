using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectShippingPage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;

        //PROCEED TO CHECK OUT NAVIGATION
        private IWebElement ProceedTocheckoutButton => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/div/form/p/button/span"));

        //CONTINUE SHOPPING NAVIGATION
        private IWebElement ContinueShoppingButton => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php"));

        //AGREE TERMS OF SERVICE
        private IWebElement TermsOfServiceCheckBox => this._driver.FindElement(By.Id("cgv"));

        public AutomationProjectShippingPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ConfirmTermsOfService()
        {
            TermsOfServiceCheckBox.Click();
        }

        public void ClickProceedToCheckOutLink()
        {
            ProceedTocheckoutButton.Click();
        }
    }
}
