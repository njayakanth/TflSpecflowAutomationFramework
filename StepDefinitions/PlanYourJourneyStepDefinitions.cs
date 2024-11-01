using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.AccessControl;
using TflSpecflowAutomationFramework.Features;
using TflSpecflowAutomationFramework.Pages;

namespace TflSpecflowAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class PlanYourJourneyStepDefinitions
    {
        IWebDriver driver;

        private PlanYourJourneyPage planYourJourneyPage;

        public PlanYourJourneyStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            planYourJourneyPage = new PlanYourJourneyPage(driver);

        }


        [Given(@"I am on the TFL home page")]
        public void GivenIAmOnTheTFLHomePage()
        {
            driver.Url = "https://tfl.gov.uk/";
            planYourJourneyPage.ClickOnCookiesAllowAll();
        }

        [When(@"I click on Plan a journey tab")]
        public void WhenIClickOnPlanAJourneyTab()
        {
            planYourJourneyPage.ClickOnPlanAJourneyTab();
            Thread.Sleep(3000);
        }

        [Then(@"I should be on Plan a journey page")]
        public void ThenIShouldBeOnPlanAJouneyPage()
        {
            planYourJourneyPage.ShouldSeePlanAJourneyPage();

        }

        [When(@"I enter the text '([^']*)' in From text field")]
        public void WhenIEnterTheTextInFromTextField(string searchFromKey)
        { 
            planYourJourneyPage.EnterFromKeyword(searchFromKey);
            Thread.Sleep(1000);
        }

        [When(@"I click on the '([^']*)' from the search suggestion")]
        public void WhenIClickOnTheFromTheSearchSuggestion(string selectFromSugg)
        {
            planYourJourneyPage.ClickSuggestion(selectFromSugg);
        }
       

        [When(@"I enter the text '([^']*)' in To text field")]
        public void WhenIEnterTheTextInToTextField(string searchToKey)
        {
            planYourJourneyPage.EnterToKeyword(searchToKey);
            Thread.Sleep(1000);
        }

        [When(@"I click on Plan my journey button")]
        public void WhenIClickOnPlanMyJourneyButton()
        {
            planYourJourneyPage.ClickPlanMyJourney();
            Thread.Sleep(5000);
        }

        [Then(@"I should see an error message under From text field")]
        public void ThenIShouldSeeAnErrorMessageUnderFromTextField()
        {
            planYourJourneyPage.ShouldSeeFromFieldError();
        }

        [Then(@"I should see an error message under To text field")]
        public void ThenIShouldSeeAnErrorMessageUnderToTextField()
        {
            planYourJourneyPage.ShouldSeeToFieldError();

        }



    }
}
