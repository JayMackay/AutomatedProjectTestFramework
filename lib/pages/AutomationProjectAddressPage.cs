using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectAddressPage
    {
        private IWebDriver _driver;

        private IWebElement _proceedToCheckout => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/form/p/button/span"));

        public AutomationProjectAddressPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private void ClickProceedToCheckout()
        {
            _proceedToCheckout.Click();
        }
    }
}
