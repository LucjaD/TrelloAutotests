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
            driver.FindElement(Selectors.CreateList).Click();
            driver.FindElement(Selectors.ListNameInput).SendKeys(listName);
            driver.FindElement(Selectors.AddListButton).Click();
        }

        public bool IsListCreated(string listName) => driver.FindElements(Selectors.ListHeaderName).Any(x => x.Text.Contains(listName));

        //public bool IsListDeleted(string listName) => driver.FindElements(Selectors.ListHeaderName).Any(x => x.Text.Contains(listName));

        public void DeleteList(string listName)
        {
            driver.FindElements(Selectors.ListHeader)
                .First(x => x.Text.Contains(listName))
                .FindElement(Selectors.ListActions)
                .Click();
            driver.FindElement(Selectors.ListArchive).Click();
        }
    }
}
