using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloCreateBoardPage : BasePage
    {
        public TrelloBoardPage CreateBoard(string BoardName)
        {
            Wait.Until(d => Driver.DriverInstance.FindElements(BoardSelectors.BoardTitleInput).Any());

            driver.FindElement(BoardSelectors.BoardTitleInput).SendKeys(BoardName);
            driver.FindElement(BoardSelectors.BoardCreateButton).Click();

            return new TrelloBoardPage();
        }
    }
}
