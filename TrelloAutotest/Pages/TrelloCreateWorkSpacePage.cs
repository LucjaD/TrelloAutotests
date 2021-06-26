using OpenQA.Selenium;
using System;
using System.Linq;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloCreateWorkSpacePage : BasePage
    {
        public void CreateNewWorkSpace(string element, string workSpaceName)
        {
            Wait.Until(d => driver.FindElements(By.XPath("//*[contains(text(),'Stwórzmy Przestrzeń roboczą')]")).Any());

            driver.FindElement(By.CssSelector("input[data-test-id='header-create-team-name-input']")).SendKeys(workSpaceName);
            driver.FindElement(By.XPath("//*[contains(text(),'Wybierz…')]")).Click();
            driver.FindElement(By.CssSelector($"div[data-test-id ='header-create-team-type-input-{element}']")).Click();
            driver.FindElement(By.XPath("//textarea[contains(text(),'')]")).SendKeys("Tu się dzieją rzeczy");
            driver.FindElement(By.XPath("//button[contains(text(),'Kontynuuj')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Później')]")).Click();
        }

        public bool IsWorkSpaceCreated(string workSpaceName)
        {
            Wait.Until(d => driver.FindElements(By.XPath($"//h1[contains(text(),'{workSpaceName}')]")).Any());

            return driver.FindElements(By.XPath($"//h1[contains(text(),'{workSpaceName}')]")).Any();
        }

        public void DeleteWorkSpace(string workSpaceName)
        {
            driver.FindElement(By.CssSelector("[aria-label='HouseIcon']")).Click();
            Wait.Until(d => driver.FindElements(By.CssSelector("span[data-test-id *= 'home-team-tab-name']")).Any());

            var tak3 = driver.FindElements(By.CssSelector("[data-test-id *= 'home-team-tab-section-']"))
                .FirstOrDefault(x => x.Text.Contains(workSpaceName, StringComparison.OrdinalIgnoreCase));
            tak3.FindElement(By.CssSelector("[data-test-id = 'home-team-settings-tab']")).Click();

            Wait.Until(d => driver.FindElements(By.ClassName("tabbed-pane-header-details"))
            .Any(x => x.Text.Contains(workSpaceName)));

            driver.FindElement(By.ClassName("quiet-button")).Click();
            driver.FindElement(By.ClassName("js-confirm")).Click();
        }

        public bool IsWorkSpaceDeleted(string workSpaceName) => driver.FindElements(By.CssSelector("[data-test-id *= 'home-team-tab-section-']"))
                .Any(x => x.Text.Contains(workSpaceName, StringComparison.OrdinalIgnoreCase));
    }
}
