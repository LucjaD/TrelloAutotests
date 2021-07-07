using NUnit.Framework;
using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloMainPage : BasePage
    {
        public TrelloMainPage() => Wait.Until(d => driver.FindElements(MainSelectors.AddBoardPanel).Any());

        public TrelloCreateBoardPage CreateNewBoardByPanel()
        {
            driver.FindElement(MainSelectors.AddBoardPanel).Click();
            return new TrelloCreateBoardPage();
        }

        public TrelloCreateBoardPage CreateNewBoardByMenu()
        {
            Wait.Until(d => driver.FindElements(MainSelectors.AddBoardButton).Any());

            driver.FindElement(MainSelectors.AddBoardButton).Click();
            return new TrelloCreateBoardPage();
        }

        public TrelloCreateWorkSpacePage CreateWorkSpace()
        {
            Wait.Until(d => driver.FindElements(MainSelectors.CreateWorkSpaceControl).Any());

            driver.FindElement(MainSelectors.CreateWorkSpaceControl).Click();
            return new TrelloCreateWorkSpacePage();
        }

        public TrelloListPage OpenBoard(string boardName)
        {
            driver.FindElement(MainSelectors.BoardTitle(boardName)).Click();
            return new TrelloListPage();
        }

        public TrelloMainPage Search(string boardName)
        {
            driver.FindElement(MainSelectors.SearchIcon).Click();
            Wait.Until(d => driver.FindElements(MainSelectors.SearchInput)).Any();
            driver.FindElement(MainSelectors.SearchInput).SendKeys(boardName);

            return this;
        }

        public TrelloBoardPage SelectSearchResult(string boardName)
        {
            Wait.Until(d => driver.FindElements(MainSelectors.SearchResult).Any());
            driver.FindElements(MainSelectors.SpecificSearchResult)
                .First(x => x.Text.Contains(boardName)).Click();

            return new TrelloBoardPage();
        }

        public TrelloMainPage OpenCreateTab()
        {
            driver.FindElement(MainSelectors.CreateTabButton).Click();
            return this;
        }

        public TrelloMainPage VerifyPassword()
        {
            Assert.IsFalse(driver.FindElements(BaseSelectors.IncorrectLoginPanel).Any());
            return this;
        }

        public TrelloMainPage VerifyLogin()
        {
            Wait.Until(d => driver.FindElements(BoardSelectors.BoardHeader).Any());
            Assert.IsTrue(driver.FindElements(BoardSelectors.BoardHeader).Any());
            return this;
        }
    }
}
