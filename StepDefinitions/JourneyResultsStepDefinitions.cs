using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.AccessControl;
using TflSpecflowAutomationFramework.Pages;

namespace TflSpecflowAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class JourneyResultsStepDefinitions
    {
        private IWebDriver driver;

        private JourneyResultsPage journeyResultsPage;

        public JourneyResultsStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            journeyResultsPage = new JourneyResultsPage(driver);
        }


        [Then(@"I should be on journey results screen")]
        public void ThenIShouldBeOnJourneyResultsScreen()
        {
            journeyResultsPage.ShouldSeeJourneyResults();
        }

        [Then(@"I should see the Walking and cycling time")]
        public void ThenIShouldSeeTheWalkingAndCyclingTime()
        {
            journeyResultsPage.ShouldSeeWalkingTime();
            journeyResultsPage.ShouldSeeCyclingTime();
        }

        [When(@"I click on Edit preferences button")]
        public void WhenIClickOnEditPreferencesButton()
        {
            journeyResultsPage.ClickOnEditPreferences();
            Thread.Sleep(1000);
        }

        [Then(@"I should see the show me section")]
        public void ThenIShouldSeeTheShowMeSection()
        {
            journeyResultsPage.ShouldSeeShowMeSection();
        }

        [When(@"I select the Routes with least walking radio button")]
        public void WhenISelectTheRoutesWithLeastWalkingRadioButton()
        {
            journeyResultsPage.ClickOnRadioButton();
        }

        [When(@"I select the Update Journey button")]
        public void WhenISelectTheUpdateJourneyButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            // Scroll down by 300 pixels
            js.ExecuteScript("window.scrollBy(0, 300);");
            Thread.Sleep(1000);
            journeyResultsPage.ClickOnUpdateButton();
            Thread.Sleep(3000);
        }

        [Then(@"I should see the journey time in results page")]
        public void ThenIShouldSeeTheJourneyTimeInResultsPage()
        {
            journeyResultsPage.ShouldSeeJourneyResults();
        }

        [When(@"I click on view details button")]
        public void WhenIClickOnViewDetailsButton()
        {
            journeyResultsPage.ClickOnViewDetails();
        }

        [Then(@"I should see the complete access information")]
        public void ThenIShouldSeeTheCompleteAccessInformation()
        {
            journeyResultsPage.ShouldSeeAccessInformation();
        }


    }
}
