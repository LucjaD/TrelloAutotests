using OpenQA.Selenium;
using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using Selectors = BoardConst;

    class TrelloCreateBoardPage : BasePage
    {
        public void CreateBoard(string BoardName)
        {
            Wait.Until(d => Driver.DriverInstance.FindElements(By.XPath(Selectors.BoardTitleInput)).Any());

            var driver = Driver.DriverInstance;

            driver.FindElement(By.XPath(Selectors.BoardTitleInput)).SendKeys(BoardName);
            driver.FindElement(By.XPath(Selectors.BoardCreateButton)).Click();
        }
    }
}
