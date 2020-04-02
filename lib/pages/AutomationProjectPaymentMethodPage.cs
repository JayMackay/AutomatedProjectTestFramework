using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectPaymentMethodPage
    {
        private IWebDriver _driver;

        private IWebElement BankWireTransfer => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?fc=module&amp;module=bankwire&amp;controller=payment"));
        private IWebElement CheckTransfer => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?fc=module&amp;module=cheque&amp;controller=payment"));

        public AutomationProjectPaymentMethodPage(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public void PayByBankWire()
        {
            BankWireTransfer.Click();
        }

        public void PayByCheck()
        {
            CheckTransfer.Click();
        }
    }
}
