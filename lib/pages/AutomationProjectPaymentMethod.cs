using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectTestFramework.lib.pages
{
    class AutomationProjectPaymentMethod
    {
        private IWebDriver _driver;
        public AutomationProjectPaymentMethod(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement BankWireTransfer => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?fc=module&amp;module=bankwire&amp;controller=payment"));
        private IWebElement CheckTransfer => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?fc=module&amp;module=cheque&amp;controller=payment"));
        private void PayByBankWire()
        {
            CheckTransfer.Click();
        }
        private void PayByCheck()
        {
            CheckTransfer.Click();
        }
    }
}
