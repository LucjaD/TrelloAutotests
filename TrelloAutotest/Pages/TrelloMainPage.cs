using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    class TrelloMainPage : BasePage
    {
        public TrelloMainPage() => Wait.Until(d => driver.FindElements(By.ClassName("mod-add")).Any());
      
        public void CreateNewBoard() => driver.FindElement(By.ClassName("mod-add")).Click();
        
        public void CreateNewBoardButton()
        {
            Wait.Until(d => driver.FindElements(By.XPath("//span[contains(text(),'Utwórz tablicę')]")).Any());

            driver.FindElement(By.XPath("//span[contains(text(),'Utwórz tablicę')]")).Click();
        }

        public void CreateWorkSpace()
        {
            Wait.Until(d => driver.FindElements(By.XPath("//span[contains(text(),'Utwórz tablicę')]")).Any());

            driver.FindElement(By.XPath("//span[contains(text(),'Utwórz przestrzeń roboczą')]")).Click();
        }
        
        public void OpenBoard(string boardName)
        {
            driver.FindElement(By.XPath($"//div[@title = '{boardName}']")).Click();
        }

        public void Search(string boardName)
        {
            driver.FindElement(By.XPath("//span[@aria-label = 'SearchIcon']")).Click();
            Wait.Until(d => driver.FindElements(By.CssSelector("input[data-test-id='header-search-input']"))).Any();
            driver.FindElement(By.CssSelector("input[data-test-id='header-search-input']")).SendKeys(boardName);

            Wait.Until(d => driver.FindElements(By.CssSelector("[data-test-id = 'header-search-popover']")).Any());
            driver.FindElements(By.CssSelector("[data-test-id = 'header-search-popover'] a[title]"))
                .First(x =>x.Text.Contains(boardName)).Click();
        }

        public void OpenCreateTab() => driver.FindElement(By.XPath("//button[@aria-label = 'Utwórz tablicę lub Przestrzeń roboczą']")).Click();
    }
}
