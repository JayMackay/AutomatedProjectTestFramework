﻿using OpenQA.Selenium;
using System.Collections.Generic;


namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectHomePage
    {
        private IWebDriver _driver;
        private string _homePageUrl = AppConfigReader.BaseUrl;

        //LOGIN NAVIGATION
        private IWebElement SignInButton => this._driver.FindElement(By.ClassName("login"));

        //SEARCH FUNCTIONALITY
        private IWebElement SearchBar => this._driver.FindElement(By.Id("search_query_top"));

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

        public void SearchFunctionality(string product)
        {
            SearchBar.SendKeys(product);
            SearchBar.Submit();
        }
    }
}
