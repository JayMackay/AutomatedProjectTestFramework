using System;
using NUnit.Framework;
using AutomationProjectTestFramework.lib;
using TechTalk.SpecFlow;

namespace AutomationProjectTestFramework.BDDTests.SteppingFunctions
{
    [Binding]
    public class SearchFunctionalityTestSteps
    {
        private AutomatedProjectWebsite _automation;

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            _automation = new AutomatedProjectWebsite("chrome");
            _automation.AutomationProjectHome.VisitHomePage();
        }
        
        [Given(@"I have entered ""(.*)"" into the search bar")]
        public void GivenIHaveEnteredIntoTheSearchBar(string dress)
        {
            _automation.AutomationProjectHome.SearchFunctionality(dress);
        }
        
        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
          
        }
        
        [Then(@"a new page with the results should be displayed")]
        public void ThenANewPageWithTheResultsShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}