using OpenQA.Selenium;
using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using Selectors = MainConst;

    class TrelloMainPage : BasePage
    {
        public TrelloMainPage() => Wait.Until(d => driver.FindElements(By.ClassName(Selectors.AddBoardPanel)).Any());
      
        public void CreateNewBoard() => driver.FindElement(By.ClassName(Selectors.AddBoardPanel)).Click();
        
        public void CreateNewBoardButton()
        {
            Wait.Until(d => driver.FindElements(By.XPath(Selectors.AddBoardButton)).Any());

            driver.FindElement(By.XPath(Selectors.AddBoardButton)).Click();
        }

        public void CreateWorkSpace()
        {
            Wait.Until(d => driver.FindElements(By.XPath(Selectors.CreateWorkSpace)).Any());

            driver.FindElement(By.XPath(Selectors.CreateWorkSpace)).Click();
        }
        
        public void OpenBoard(string boardName)
        {
            driver.FindElement(By.XPath(Selectors.OpenBoard(boardName))).Click();
        }

        public void Search(string boardName)
        {
            driver.FindElement(By.XPath(Selectors.SearchIcon)).Click();
            Wait.Until(d => driver.FindElements(By.CssSelector(Selectors.SearchInput))).Any();
            driver.FindElement(By.CssSelector(Selectors.SearchInput)).SendKeys(boardName);

            Wait.Until(d => driver.FindElements(By.CssSelector(Selectors.SearchResult)).Any());
            driver.FindElements(By.CssSelector(Selectors.SearchResult + " a[title]"))
                .First(x =>x.Text.Contains(boardName)).Click();
        }

        public void OpenCreateTab() => driver.FindElement(By.XPath(Selectors.CreateTab)).Click();
    }
}
