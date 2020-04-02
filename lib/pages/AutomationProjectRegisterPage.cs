using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectRegisterPage
    {

        private IWebDriver _driver;
        private string _loginPageUrl = AppConfigReader.LoginUrl;


        //Email input
        private IWebElement EmailInput => this._driver.FindElement(By.Id("email_create"));

        private IWebElement ErrorBox => this._driver.FindElement(By.Id("create_account_error"));

        private IWebElement FormCheck => this._driver.FindElement(By.XPath("//div[@class='form-group form-ok']"));


        public AutomationProjectRegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void InputEmail(string email)
        {
            EmailInput.SendKeys(email);
            
        }

        public void Clickoff()
        {
            Thread.Sleep(100);
            EmailInput.SendKeys(Keys.Tab);
        }

        public void GotoRegistrationPage()
        {
            _driver.Navigate().GoToUrl(_loginPageUrl);

        }

        public bool GoodEmailInput()
        {
            if (FormCheck.Enabled)
            {
                return true;
            }

            return false;
        }
    }
}
