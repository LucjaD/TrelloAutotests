using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using Selectors = MainSelectors;

    class TrelloMainPage : BasePage
    {
        public TrelloMainPage() => Wait.Until(d => driver.FindElements(Selectors.AddBoardPanel).Any());

        public void CreateNewBoardByPanel() => driver.FindElement(Selectors.AddBoardPanel).Click();

        public void CreateNewBoardByMenu()
        {
            Wait.Until(d => driver.FindElements(Selectors.AddBoardButton).Any());

            driver.FindElement(Selectors.AddBoardButton).Click();
        }

        public void CreateWorkSpace()
        {
            Wait.Until(d => driver.FindElements(Selectors.CreateWorkSpaceControl).Any());

            driver.FindElement(Selectors.CreateWorkSpaceControl).Click();
        }

        public void OpenBoard(string boardName)
        {
            driver.FindElement(Selectors.BoardTitle(boardName)).Click();
        }

        public void Search(string boardName)
        {
            driver.FindElement(Selectors.SearchIcon).Click();
            Wait.Until(d => driver.FindElements(Selectors.SearchInput)).Any();
            driver.FindElement(Selectors.SearchInput).SendKeys(boardName);
        }

        public void SelectSearchResult(string boardName)
        {
            Wait.Until(d => driver.FindElements(Selectors.SearchResult).Any());
            driver.FindElements(Selectors.SpecificSearchResult)
                .First(x => x.Text.Contains(boardName)).Click();
        }

        public void OpenCreateTab() => driver.FindElement(Selectors.CreateTabButton).Click();
    }
}
