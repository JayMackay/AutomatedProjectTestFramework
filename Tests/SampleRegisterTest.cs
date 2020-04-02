using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using AutomationProjectTestFramework.lib;
using AutomationProjectTestFramework.lib.pages;
using OpenQA.Selenium;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AutomationProjectTestFramework.Tests
{
    [TestFixture]
    // [Parallelizable(ParallelScope.Self)]
    public class SampleRegisterTest
    {
        // Instantiate the page objects, include all functionality for the web pages
        // will see that later
        public AutomatedProjectWebsite RegisterPage; //= new BbcWebsite("chrome");

        [SetUp]
        public void SetUp()
        {
            RegisterPage = new AutomatedProjectWebsite("chrome");
        }

        [Test]
        public void EnterCorrectDetailsForLogin()
        {
            RegisterPage.AutomationProjectHomePage.GotoRegistrationPage();

            RegisterPage.AutomationProjectHomePage.InputEmail("thisemail@website.com");


            //TODO
            // Assert.AreEqual(1,1);


            Assert.AreEqual(true, RegisterPage.AutomationProjectHomePage.GoodEmailInput());
            CleanUp();
        }

        [TearDown]
        public void CleanUp()
        {
            RegisterPage.seleniumDriver.Quit();
        }

    }
}
