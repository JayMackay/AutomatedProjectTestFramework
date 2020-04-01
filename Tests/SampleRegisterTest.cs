﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using  AutomationProjectTestFramework.lib;
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
        public AutomationProjectWebsite RegisterPage; //= new BbcWebsite("chrome");

        [SetUp]
        public void SetUp()
        {
            RegisterPage = new AutomationProjectWebsite("chrome");
        }

        [Test]
        public void EnterCorrectDetailsForLogin()
        {
            RegisterPage.AutomationProjectRegisterPage.GotoRegistrationPage();

            RegisterPage.AutomationProjectRegisterPage.InputEmail("thisemail@website.com");
            

            //TODO
            Assert.AreEqual(1,1);


            //Assert.AreEqual(true, RegisterPage.AutomationProjectRegisterPage.GoodEmailInput());
        }

    }
}