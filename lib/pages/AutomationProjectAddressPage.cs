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
        private IWebElement ProceedToCheckout => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?controller=order&step=1"));

        public AutomationProjectAddressPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private void ClickProceedToCheckout()
        {
            ProceedToCheckout.Click();
        }
    }
}
