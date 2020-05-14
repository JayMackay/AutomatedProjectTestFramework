using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectRegisterPage
    {

        private IWebDriver _driver;
        private string _loginPageUrl = AppConfigReader.LoginUrl;


        //EMAIL INPUT
        private IWebElement EmailInput => this._driver.FindElement(By.Id("email_create"));
        private IWebElement ErrorMessage => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/div/div[1]/form/div/div[1]/ol/li"));
        private IWebElement CreateAccountButton => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button/span"));
        private IWebElement FormCheck => this._driver.FindElement(By.XPath("//div[@class='form-group form-ok']"));
        private IWebElement InvalidFormCheck => this._driver.FindElement(By.XPath("//div[@class='form-group form-error']"));


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

        public void CreateAccount()
        {
            CreateAccountButton.Click();
        }

        public bool GoodEmailInput()
        {
            if (FormCheck.Enabled)
            {
                return true;
            }
            return false;
        }

        public bool BadEmailInput()
        {
            if (InvalidFormCheck.Enabled)
            {
                return true;
            }
            return false;
        }

        public string RegistrationValidation()
        {
            return ErrorMessage.Text;
        }
    }
}
