using OpenQA.Selenium;
using System;
using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using Selectors = WorkSpaceConst;
    using BaseSelectors = BaseConst;

    public class TrelloCreateWorkSpacePage : BasePage
    {
        public void CreateNewWorkSpace(string element, string workSpaceName)
        {
            Wait.Until(d => driver.FindElements(By.CssSelector(Selectors.WorkSpaceNameInput)).Any());

            driver.FindElement(By.CssSelector(Selectors.WorkSpaceNameInput)).SendKeys(workSpaceName);
            driver.FindElement(By.XPath(Selectors.WorkSpaceTypeDropdown)).Click();
            driver.FindElement(By.CssSelector(Selectors.WorkSpaceTypeSelect(element))).Click();
            driver.FindElement(By.XPath(Selectors.WorkSpaceDescriptionInput)).SendKeys("Tu się dzieją rzeczy");
            driver.FindElement(By.XPath(Selectors.WorkSpaceContinueButton)).Click();
            driver.FindElement(By.XPath(Selectors.WorkSpaceLaterButton)).Click();
        }

        public bool IsWorkSpaceCreated(string workSpaceName)
        {
            Wait.Until(d => driver.FindElements(By.XPath(Selectors.WorkSpaceCreated(workSpaceName))).Any());

            return driver.FindElements(By.XPath(Selectors.WorkSpaceCreated(workSpaceName))).Any();
        }

        public void DeleteWorkSpace(string workSpaceName)
        {
            driver.FindElement(By.CssSelector(Selectors.HouseIcon)).Click();
            Wait.Until(d => driver.FindElements(By.CssSelector(Selectors.WorkSpaceTab)).Any());

            var workSpaceList = driver.FindElements(By.CssSelector(Selectors.WorkSpaceTab))
                .FirstOrDefault(x => x.Text.Contains(workSpaceName, StringComparison.OrdinalIgnoreCase));
            workSpaceList.FindElement(By.CssSelector(Selectors.WorkSpaceSettings)).Click();

            Wait.Until(d => driver.FindElements(By.ClassName(Selectors.WorkSpaceName))
            .Any(x => x.Text.Contains(workSpaceName)));

            driver.FindElement(By.ClassName(Selectors.WorkSpaceDeleteButton)).Click();
            driver.FindElement(By.ClassName(BaseSelectors.ConfirmButton)).Click();
        }

        public bool IsWorkSpaceDeleted(string workSpaceName) => driver.FindElements(By.CssSelector(Selectors.WorkSpaceDeleted))
                .Any(x => x.Text.Contains(workSpaceName, StringComparison.OrdinalIgnoreCase));
    }
}
