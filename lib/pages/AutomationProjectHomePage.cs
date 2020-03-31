using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    class AutomationProjectHomePage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;

        //SHOPPING CART NAVIGATION
        private IWebElement ShoppingCartButton => this._driver.FindElement(By.ClassName("shopping_cart"));

        //LOGIN NAVIGATION
        private IWebElement SignInButton => this._driver.FindElement(By.ClassName("login"));

        public AutomationProjectHomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void VisitHomePage()
        {
            _driver.Navigate().GoToUrl(_homePageUrl);
        }

        public void ClickSignInLink()
        {
            SignInButton.Click();
        }
    }
}
