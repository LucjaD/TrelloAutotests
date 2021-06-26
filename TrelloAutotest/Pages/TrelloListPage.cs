using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    class TrelloListPage : BasePage
    {
        public void CreateList(string listName)
        {
            driver.FindElement(By.XPath("//span[contains(text(), 'Dodaj ') and contains(text(), 'listę')]")).Click();
            driver.FindElement(By.XPath("//input[@placeholder = 'Wprowadź tytuł listy']")).SendKeys(listName);
            driver.FindElement(By.ClassName("mod-list-add-button")).Click();
        }

        public bool IsListCreated() => driver.FindElement(By.ClassName("js-list-content")).Displayed;

        public bool IsListDeleted(string listName) => driver.FindElements(By.ClassName("list-header-name")).Any(x => x.Text.Contains(listName));

        public void DeleteList()
        {
            var ListsCollection = driver.FindElements(By.ClassName("js-list-content"));

            driver.FindElements(By.CssSelector(".list-header "))
                .First(x => x.Text.Contains("Lista do usunięcia"))
                .FindElement(By.CssSelector("[aria-label='Akcje listy']"))
                .Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Zarchiwizuj tę listę')]")).Click();
        }
    }
}
