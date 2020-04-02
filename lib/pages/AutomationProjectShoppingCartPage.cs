using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectShoppingCartPage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;

        //PROCEED TO CHECK OUT NAVIGATION
        private IWebElement ProceedTocheckoutButton => this._driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/div/p[2]/a[1]/span"));

        //CONTINUE SHOPPING NAVIGATION
        private IWebElement ContinueShoppingButton => this._driver.FindElement(By.LinkText("http://automationpractice.com/index.php"));

        public AutomationProjectShoppingCartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(_homePageUrl);
        }

        public void ClickProceedToCheckOutLink()
        {
            ProceedTocheckoutButton.Click();
        }
    }
}