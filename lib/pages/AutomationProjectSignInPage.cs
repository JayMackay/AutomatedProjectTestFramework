using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace AutomationProjectTestFramework.lib.pages
{
    class AutomationProjectSignInPage
    {
        private IWebDriver _driver;
        private IWebElement usernameField => _driver.FindElement(By.Id("email"));
        private IWebElement passwordField => _driver.FindElement(By.Id("passwd"));

        public AutomationProjectSignInPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private void EnterValidEmail(string email)
        {
            usernameField.SendKeys(email);
        }
        private void EnterValidPassword(string password)
        {
            passwordField.SendKeys(password);
            passwordField.Submit();
        }
    }

}
