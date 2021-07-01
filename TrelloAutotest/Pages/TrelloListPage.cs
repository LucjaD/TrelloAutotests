using System.Linq;
using TrelloAutotest.Messages;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    class TrelloListPage : BasePage
    {
        public void CreateList(string listName)
        {
            driver.FindElement(ListSelectors.CreateListButton).Click();
            driver.FindElement(ListSelectors.ListNameInput).SendKeys(listName);
            driver.FindElement(ListSelectors.AddListButton).Click();
        }

        public bool IsListCreated(string listName) => driver.FindElements(ListSelectors.ListHeaderName).Any(x => x.Text.Contains(listName));

        public void DeleteList(string listName)
        {
            driver.FindElements(ListSelectors.ListHeader)
                .First(x => x.Text.Contains(listName))
                .FindElement(ListSelectors.ListActions)
                .Click();
            driver.FindElement(ListSelectors.ListArchive).Click();
        }
    }
}
