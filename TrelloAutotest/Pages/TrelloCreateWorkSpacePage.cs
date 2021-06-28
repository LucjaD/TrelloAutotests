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
            Wait.Until(d => driver.FindElements(Selectors.WorkSpaceNameInput).Any());

            driver.FindElement(Selectors.WorkSpaceNameInput).SendKeys(workSpaceName);
            driver.FindElement(Selectors.WorkSpaceTypeDropdown).Click();
            driver.FindElement(Selectors.WorkSpaceTypeSelect(element)).Click();
            driver.FindElement(Selectors.WorkSpaceDescriptionInput).SendKeys("Tu się dzieją rzeczy");
            driver.FindElement(Selectors.WorkSpaceContinueButton).Click();
            driver.FindElement(Selectors.WorkSpaceLaterButton).Click();
        }

        public bool IsWorkSpaceCreated(string workSpaceName)
        {
            Wait.Until(d => driver.FindElements(Selectors.WorkSpaceCreated(workSpaceName)).Any());

            return driver.FindElements(Selectors.WorkSpaceCreated(workSpaceName)).Any();
        }

        public void DeleteWorkSpace(string workSpaceName)
        {
            driver.FindElement(Selectors.HouseIcon).Click();
            Wait.Until(d => driver.FindElements(Selectors.WorkSpaceTab).Any());

            var workSpaceList = driver.FindElements(Selectors.WorkSpaceTab)
                .FirstOrDefault(x => x.Text.Contains(workSpaceName, StringComparison.OrdinalIgnoreCase));
            workSpaceList.FindElement(Selectors.WorkSpaceSettings).Click();

            Wait.Until(d => driver.FindElements(Selectors.WorkSpaceName)
            .Any(x => x.Text.Contains(workSpaceName)));

            driver.FindElement(Selectors.WorkSpaceDeleteButton).Click();
            driver.FindElement(BaseSelectors.ConfirmButton).Click();
        }

        public bool IsWorkSpaceDeleted(string workSpaceName) => driver.FindElements(Selectors.WorkSpaceDeleted)
                .Any(x => x.Text.Contains(workSpaceName, StringComparison.OrdinalIgnoreCase));
    }
}
