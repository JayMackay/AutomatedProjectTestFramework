﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationProjectTestFramework.lib.pages
{
    public class AutomationProjectDressPage
    {
        private IWebDriver _driver;

        private IWebElement AddToCart => this._driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(1) > div > div.right-block > div.button-container > a.button.ajax_add_to_cart_button.btn.btn-default > span"));
        private IWebElement ProceedToCheckout => this._driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a/span"));

        public AutomationProjectDressPage(IWebDriver driver)
        {
            _driver = driver;
        }
        
        public void AddProduct()
        {
            AddToCart.Click();
        }

        public void ProceedToCart()
        {
            ProceedToCheckout.Click();
        }
    }
}