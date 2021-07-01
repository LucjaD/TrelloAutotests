using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    class TrelloMainPage : BasePage
    {
        public TrelloMainPage() => Wait.Until(d => driver.FindElements(MainSelectors.AddBoardPanel).Any());

        public void CreateNewBoardByPanel() => driver.FindElement(MainSelectors.AddBoardPanel).Click();

        public void CreateNewBoardByMenu()
        {
            Wait.Until(d => driver.FindElements(MainSelectors.AddBoardButton).Any());

            driver.FindElement(MainSelectors.AddBoardButton).Click();
        }

        public void CreateWorkSpace()
        {
            Wait.Until(d => driver.FindElements(MainSelectors.CreateWorkSpaceControl).Any());

            driver.FindElement(MainSelectors.CreateWorkSpaceControl).Click();
        }

        public void OpenBoard(string boardName)
        {
            driver.FindElement(MainSelectors.BoardTitle(boardName)).Click();
        }

        public void Search(string boardName)
        {
            driver.FindElement(MainSelectors.SearchIcon).Click();
            Wait.Until(d => driver.FindElements(MainSelectors.SearchInput)).Any();
            driver.FindElement(MainSelectors.SearchInput).SendKeys(boardName);
        }

        public void SelectSearchResult(string boardName)
        {
            Wait.Until(d => driver.FindElements(MainSelectors.SearchResult).Any());
            driver.FindElements(MainSelectors.SpecificSearchResult)
                .First(x => x.Text.Contains(boardName)).Click();
        }

        public void OpenCreateTab() => driver.FindElement(MainSelectors.CreateTabButton).Click();
    }
}
