using NUnit.Framework;
using System.Linq;
using TrelloAutotest.Messages;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloListPage : BasePage
    {
        public TrelloListPage CreateList(string listName)
        {
            driver.FindElement(ListSelectors.CreateListButton).Click();
            driver.FindElement(ListSelectors.ListNameInput).SendKeys(listName);
            driver.FindElement(ListSelectors.AddListButton).Click();

            return this;
        }

        public TrelloListPage IsListCreated(string listName, bool assertFlag)
        {
            if (assertFlag) Assert.IsTrue(driver.FindElements(ListSelectors.ListHeaderName).Any(x => x.Text.Contains(listName)));
            else Assert.IsFalse(driver.FindElements(ListSelectors.ListHeaderName).Any(x => x.Text.Contains(listName)));

            return this;
        }

        public TrelloListPage DeleteList(string listName)
        {
            driver.FindElements(ListSelectors.ListHeader)
                .First(x => x.Text.Contains(listName))
                .FindElement(ListSelectors.ListActions)
                .Click();
            driver.FindElement(ListSelectors.ListArchive).Click();

            return this;
        }
    }
}
