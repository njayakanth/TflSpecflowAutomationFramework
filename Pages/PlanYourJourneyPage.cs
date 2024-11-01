using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TflSpecflowAutomationFramework.Pages
{
    public class PlanYourJourneyPage
    {
        private IWebDriver driver;


        IWebElement cookiesAllowAll => driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"));
        IWebElement planAJourneyTab => driver.FindElement(By.Id("plan-journey-button"));
        IWebElement planAJourneyPage =>  driver.FindElement(By.XPath("//*[text()='Plan a journey']"));
        IWebElement enterFromFiled => driver.FindElement(By.Id("InputFrom"));
        IList<IWebElement> suggesList => driver.FindElements(By.XPath("//span[@role='option']"));
        IWebElement enterToFiled => driver.FindElement(By.Id("InputTo"));
        IWebElement planAJourneyButton => driver.FindElement(By.Id("plan-journey-button"));
        IWebElement fromInputError => driver.FindElement(By.Id("InputFrom-error"));
        IWebElement toInputError => driver.FindElement(By.Id("InputTo-error"));

        public PlanYourJourneyPage(IWebDriver driver) 
        { 
            this.driver = driver;
        }
        public void ClickOnCookiesAllowAll()
        {
            cookiesAllowAll.Click();
        }

        public void ClickOnPlanAJourneyTab()
        {
            planAJourneyTab.Click();
        }

        public void ShouldSeePlanAJourneyPage()
        {
            planAJourneyPage.Equals(planAJourneyPage);
        }

        public void EnterFromKeyword(string searchFromKey)
        {
            enterFromFiled.SendKeys(searchFromKey);
            Thread.Sleep(1000);
        }

        public void ClickSuggestion(string selectFromSugg)
        {
            foreach (var suggestion in suggesList)

            {
                if (suggestion.Text.Equals(selectFromSugg))
                {
                    suggestion.Click();
                    break;
                }
            }
        }
        public void EnterToKeyword(string searchToKey)
        {
            enterToFiled.SendKeys(searchToKey);
            Thread.Sleep(1000);
        }
        public void ClickPlanMyJourney()
        {
            planAJourneyButton.Click();
            Thread.Sleep(3000);
        }

        public void ShouldSeeFromFieldError()
        {
            fromInputError.Equals("The From field is required.");
           
        }

        public void ShouldSeeToFieldError()
        {
            toInputError.Equals("The To field is required");
           
        }




    }
}
