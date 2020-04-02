using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectMyAccountPage
    {
        private IWebDriver _driver;
        public AutomationProjectMyAccountPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement _searchBar => this._driver.FindElement(By.Id("search_query_top"));
        private void SearchProduct(string product)
        {
            _searchBar.SendKeys(product);
            _searchBar.Submit();
        }
    }
}
