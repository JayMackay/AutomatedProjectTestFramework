using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectSignInPage
    {
        private IWebDriver _driver;
        private IWebElement _usernameField => _driver.FindElement(By.Id("email"));
        private IWebElement _passwordField => _driver.FindElement(By.Id("passwd"));
        private IWebElement _confirmationButton => _driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/div/div[2]/form/div/p[2]/button/span"));

        public AutomationProjectSignInPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private void EnterValidEmail(string email)
        {
            _usernameField.SendKeys(email);
        }

        private void EnterValidPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void ConfirmationButton()
        {
            _confirmationButton.Click();
        }
    }
}
