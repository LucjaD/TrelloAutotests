using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    class TrelloListPage : BasePage
    {
        public IWebDriver driver;
        public void CreateList()
        {
            driver = Driver.DriverInstance;
            driver.FindElement(By.XPath("//span[contains(text(),'Dodaj kolejną listę')]")).Click();
            driver.FindElement(By.XPath("//input[@placeholder = 'Wprowadź tytuł listy']")).SendKeys("Nowa lista");
            driver.FindElement(By.ClassName("mod-list-add-button")).Click();
        }

        public bool IsListCreated()
        {
            return Driver.DriverInstance.FindElement(By.ClassName("js-list-content")).Displayed;
        }

        public void DeleteList()
        {
            driver = Driver.DriverInstance;
            var ListsCollection = driver.FindElements(By.ClassName("js-list-content"));

            var ListToDelete = ListsCollection.First(n => n.FindElements(By.CssSelector("[aria-label = \"Lista do usunięcia\"]")).Any());

            //var costam = ListToDelete.FindElement(By.TagName("textarea")).GetAttribute("aria-label");

            var PropertiesButton = ListToDelete.FindElement(By.XPath("//a[@aria-label = 'Akcje listy']"));
            PropertiesButton.Click();
            PropertiesButton.FindElement(By.XPath("//a[contains(text(),'Zarchiwizuj tę listę')]")).Click();
        }

        //public bool IsListDeleted()
        //{
        //    var ListsCollection = driver.FindElements(By.ClassName("js-list-content"));
        //    return ListsCollection.First(n => n.FindElement(By.XPath("//textarea[contains(text(),'Lista do usunięcia')]")).Displayed).Displayed;
        //} 
    }
}
