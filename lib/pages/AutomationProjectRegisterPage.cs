using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    class AutomationProjectRegisterPage
    {

        private IWebDriver _driver;
        private string _loginPageUrl = AppConfigReader.LoginUrl;


        //Email input
        private IWebElement EmailInput => this._driver.FindElement(By.Id("email_create"));

        private IWebElement ErrorBox => this._driver.FindElement(By.Id("create_account_error"));


        public AutomationProjectRegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void InputEmail(string email)
        {
            EmailInput.SendKeys(email);
        }

        public void GotoRegistrationPage()
        {
            _driver.Navigate().GoToUrl(_loginPageUrl);

        }
    }
}
