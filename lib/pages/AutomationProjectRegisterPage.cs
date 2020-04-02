using System.Runtime.CompilerServices;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectRegisterPage
    {

        private IWebDriver _driver;
        private string _loginPageUrl = AppConfigReader.LoginUrl;


        //EMAIL INPUT
        private IWebElement EmailInput => this._driver.FindElement(By.Id("email_create"));
        private IWebElement ErrorBox => this._driver.FindElement(By.Id("create_account_error"));
        //private IWebElement FormCheck => this._driver.FindElement(By.XPath("//div[@class='form-group form-ok']"));

        //------Registration form test ------//

        private IWebElement FullName => this._driver.FindElement(By.Id("customer_firstname"));
        private IWebElement LastName => this._driver.FindElement(By.Id("customer_lastname"));
        private IWebElement Password => this._driver.FindElement(By.Id("passwd"));
        private IWebElement FirstName => this._driver.FindElement(By.Id("firstname"));
        private IWebElement lasteNameAgain => this._driver.FindElement(By.Id("lastname"));
        private IWebElement Address => this._driver.FindElement(By.Id("address1"));
        private IWebElement City => this._driver.FindElement(By.Id("city"));
        private SelectElement State => (SelectElement)this._driver.FindElement(By.Id("id_state"));





        


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
            if (this._driver.FindElement(By.XPath("//div[@class='form-group form-ok']")) != null)
            {
                return true;
            }

            return false;
        }







    }
}
