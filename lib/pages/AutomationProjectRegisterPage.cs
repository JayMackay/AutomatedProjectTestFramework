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

        private IWebElement Title => this._driver.FindElement(By.Id("uniform-id_gender1"));
        private IWebElement FullName => this._driver.FindElement(By.Id("customer_firstname"));
        private IWebElement LastName => this._driver.FindElement(By.Id("customer_lastname"));
        private IWebElement Password => this._driver.FindElement(By.Id("passwd"));

        private SelectElement Day => (SelectElement)this._driver.FindElement(By.Id("days"));
        private SelectElement Month => (SelectElement)this._driver.FindElement(By.Id("uniform-months"));
        private SelectElement Year => (SelectElement)this._driver.FindElement(By.Id("years"));


        private IWebElement FirstName => this._driver.FindElement(By.Id("firstname"));
        private IWebElement lastNameAgain => this._driver.FindElement(By.Id("lastname"));
        private IWebElement Address => this._driver.FindElement(By.Id("address1"));
        private IWebElement City => this._driver.FindElement(By.Id("city"));


        private SelectElement State => (SelectElement)this._driver.FindElement(By.Id("id_state"));

        private IWebElement Zip => this._driver.FindElement(By.Id("postcode"));

        private SelectElement Country => (SelectElement)this._driver.FindElement(By.Id("id_country"));

        private IWebElement Mobile_phone => this._driver.FindElement(By.Id("phone"));
        private IWebElement AddressName => this._driver.FindElement(By.Id("alias"));






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

        public void inputFullName(string input)
        {
            FullName.SendKeys(input);
        }

        public void inputLastName(string input)
        {
            LastName.SendKeys(input);
        }
        public void inputPassword(string input)
        {
            Password.SendKeys(input);
        }
        public void inputDay()
        {
            Day.SelectByIndex(2);
        }
        public void inputMonth()
        {
            Month.SelectByIndex(2);
        }
        public void inputYear()
        {
            Year.SelectByIndex(20);
        }
        public void inputFname(string input)
        {
            FirstName.SendKeys(input);
        }
        public void inputLname(string input)
        {
            lastNameAgain.SendKeys(input);
        }
        public void inputAddress(string input)
        {
            Address.SendKeys(input);
        }
        public void inputCity(string input)
        {
            City.SendKeys(input);
        }
        public void inputSate()
        {
            State.SelectByIndex(2);
        }
        public void inputZip(string input)
        {
            Zip.SendKeys(input);
        }
        public void inputCounty(string input)
        {
            Country.SelectByIndex(2);
        }
        public void input(string input)
        {
            Mobile_phone.SendKeys(input);
        }
        public void inputAddressName(string input)
        {
            AddressName.SendKeys(input);
        }








    }
}
