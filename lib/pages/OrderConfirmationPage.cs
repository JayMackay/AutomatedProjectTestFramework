using OpenQA.Selenium;
using NUnit;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectConfirmationPage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;
        
        //CONFIRM ORDER BUTTON
        private IWebElement OrderConfirmationMessage => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/div/p/strong"));

        public AutomationProjectConfirmationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(_homePageUrl);
        }

        public string ConfirmOrderConfirmationMessage()
        {
            return OrderConfirmationMessage.Text;
        }
    }
}
