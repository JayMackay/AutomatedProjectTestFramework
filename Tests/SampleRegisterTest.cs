using NUnit.Framework;
using AutomationProjectTestFramework.lib;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AutomationProjectTestFramework.Tests
{
    [TestFixture]
    public class SampleRegisterTest
    {
        //Instantiate the page objects, include all functionality for the web pages
        public AutomatedProjectWebsite RegisterPage;

        [SetUp]
        public void SetUp()
        {
            RegisterPage = new AutomatedProjectWebsite("chrome");
        }

        [Test]
        public void EnterCorrectDetailsForLogin()
        {
            RegisterPage.AutomationProjectRegister.GotoRegistrationPage();
            RegisterPage.AutomationProjectRegister.InputEmail("thisemail@website.com");
            RegisterPage.AutomationProjectRegister.Clickoff();

            Assert.AreEqual(true, RegisterPage.AutomationProjectRegister.GoodEmailInput());
            CleanUp();
        }

        [TearDown]
        public void CleanUp()
        {
            RegisterPage.seleniumDriver.Quit();
        }
    }
}
