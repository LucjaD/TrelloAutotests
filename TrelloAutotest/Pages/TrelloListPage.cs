using OpenQA.Selenium;
using System.Linq;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using Selectors = ListConst;

    class TrelloListPage : BasePage
    {
        public void CreateList(string listName)
        {
            driver.FindElement(By.XPath(Selectors.CreateList)).Click();
            driver.FindElement(By.XPath(Selectors.ListNameInput)).SendKeys(listName);
            driver.FindElement(By.ClassName(Selectors.AddListButton)).Click();
        }

        public bool IsListCreated(string listName) => driver.FindElements(By.ClassName(Selectors.ListHeaderName)).Any(x => x.Text.Contains(listName));

        public bool IsListDeleted(string listName) => driver.FindElements(By.ClassName(Selectors.ListHeaderName)).Any(x => x.Text.Contains(listName));

        public void DeleteList(string listName)
        {
            driver.FindElements(By.CssSelector(Selectors.ListHeader))
                .First(x => x.Text.Contains(listName))
                .FindElement(By.CssSelector(Selectors.ListActions))
                .Click();
            driver.FindElement(By.XPath(Selectors.ListArchive)).Click();
        }
    }
}
