using OpenQA.Selenium;
using System;

namespace TflSpecflowAutomationFramework.Pages
{
    public class JourneyResultsPage
    {
        private IWebDriver driver;

        IWebElement journeyResults => driver.FindElement(By.XPath("//div[@class='journey-time no-map']"));
        IWebElement journeyResultsTitle => driver.FindElement(By.Name("Journey results"));
        IWebElement cyclingTime => driver.FindElement(By.XPath("//a[@class='journey-box cycling']"));
        IWebElement walkingTime => driver.FindElement(By.XPath("//a[@class='journey-box walking']"));
        IList<IWebElement> journeyPreference => driver.FindElements(By.XPath("//label[@class='boxed-label-for-input']"));
        IWebElement showMeSection =>  driver.FindElement(By.XPath("//*[text()='Show me']"));
        IWebElement updateButton => driver.FindElement(By.XPath("(//input[@type='button' and @class='secondary-button cancel-button' and @value='Cancel'])"));
        IWebElement editPreferences => driver.FindElement(By.XPath("//button[@class='toggle-options more-options']"));
        IWebElement viewDetailsButton => driver.FindElement(By.XPath("(//button[@class='secondary-button show-detailed-results view-hide-details' and @data-show-text='View details'])"));
        IWebElement upStairs => driver.FindElement(By.XPath("(//a[@class='up-stairs tooltip-container' and @aria-label='Up stairs'])"));
        IWebElement upLift => driver.FindElement(By.XPath("(//a[@class='up-lift tooltip-container' and @aria-label='Up lift'])"));
        IWebElement levelWalkway => driver.FindElement(By.XPath("(//a[@class='level-walkway tooltip-container' and @aria-label='Level walkway'])"));

        public JourneyResultsPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public void ShouldSeeJourneyResults()
        {
            journeyResults.Equals("Total time");
     
        }
        public void ShouldSeeJourneyTitle()
        {
            journeyResultsTitle.Equals(journeyResultsTitle);

        }

        public void ClickOnRadioButton()
        {
            foreach (var radioButton in journeyPreference)
            {
                if (radioButton.Text.Equals("Routes with least walking"))
                {
                    radioButton.Click();
                    break;
                }
            }

        }

        public void ClickOnViewDetails()
        {
            viewDetailsButton.Click();
        }

        public void ClickOnEditPreferences()
        {
            editPreferences.Click();
        }
        public void ClickOnUpdateButton()
        {
            updateButton.Submit();
            Thread.Sleep(5000);
        }

        public void ShouldSeeCyclingTime()
        {
            cyclingTime.Equals(cyclingTime);

        }

        public void ShouldSeeWalkingTime()
        {
            walkingTime.Equals(walkingTime);

        }

        public void ShouldSeeShowMeSection()
        {
            showMeSection.Equals(showMeSection);

        }

        public void ShouldSeeAccessInformation()
        {
            upStairs.Equals(upStairs);
            upLift.Equals(upLift);
            levelWalkway.Equals(levelWalkway);

        }



    }
}
