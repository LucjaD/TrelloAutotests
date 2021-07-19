using NUnit.Framework;
using System;
using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloCreateWorkSpacePage : BasePage
    {
        public TrelloCreateWorkSpacePage CreateNewWorkSpace(string element, string workSpaceName)
        {
            Wait.Until(d => driver.FindElements(WorkSpaceSelectors.WorkSpaceNameInput).Any());

            driver.FindElement(WorkSpaceSelectors.WorkSpaceNameInput).SendKeys(workSpaceName);
            driver.FindElement(WorkSpaceSelectors.WorkSpaceTypeDropdown).Click();
            driver.FindElement(WorkSpaceSelectors.WorkSpaceTypeDropdownElement(element)).Click();
            driver.FindElement(WorkSpaceSelectors.WorkSpaceDescriptionInput).SendKeys("Tu się dzieją rzeczy");
            driver.FindElement(WorkSpaceSelectors.WorkSpaceContinueButton).Click();
            driver.FindElement(WorkSpaceSelectors.WorkSpaceLaterButton).Click();

            return this;
        }

        public TrelloCreateWorkSpacePage VerifyWorkspaceWasCreated(string workSpaceName)
        {
            Wait.Until(d => driver.FindElements(WorkSpaceSelectors.WorkSpaceTitle(workSpaceName)).Any());

            Assert.IsTrue(driver.FindElements(WorkSpaceSelectors.WorkSpaceTitle(workSpaceName)).Any());
            return this;
        }

        public TrelloCreateWorkSpacePage VerifyWorkSpaceWasDeleted(string workSpaceName)
        {
            Assert.IsFalse(
                driver
                    .FindElements(WorkSpaceSelectors.DeletedWorkSpace)
                    .Any(x => x.Text.Contains(workSpaceName, StringComparison.OrdinalIgnoreCase))
            );

            return this;
        }
    }
}
