using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
   public class AutomationProjectOrderSummaryPage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;

        //CONFIRM ORDER BUTTON
        private IWebElement ConfirmOrderButton => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php?controller=order&amp;step=3"));

        public AutomationProjectOrderSummaryPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(_homePageUrl);
        }

        public void ClickConfirmOrderLink()
        {
            ConfirmOrderButton.Click();
        }
    }
}
