using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using Selectors = BoardSelectors;

    class TrelloCreateBoardPage : BasePage
    {
        public void CreateBoard(string BoardName)
        {
            Wait.Until(d => Driver.DriverInstance.FindElements(Selectors.BoardTitleInput).Any());

            driver.FindElement(Selectors.BoardTitleInput).SendKeys(BoardName);
            driver.FindElement(Selectors.BoardCreateButton).Click();
        }
    }
}
