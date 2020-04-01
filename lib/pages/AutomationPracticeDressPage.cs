using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    class AutomationProjectDressPage
    {
        private IWebDriver _driver;
        public AutomationProjectDressPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement AddToCart => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?controller=cart&amp;add=1&amp;id_product=5&amp;token=1f3ac3c3a3091ee5c3d0cd5ca0301c43"));
        private IWebElement ViewCart => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?controller=order"));
        private void AddProduct()
        {
            AddToCart.Click();
        }
        private void ProceedToCart()
        {
            ViewCart.Click();
        }
    }
}