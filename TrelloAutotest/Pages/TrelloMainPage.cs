using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    class TrelloMainPage : BasePage
    {
        public void CreateNewBoard()
        {
            Wait.Until(d => Driver.DriverInstance.FindElements(By.ClassName("mod-add")).Any());
            Driver.DriverInstance.FindElement(By.ClassName("mod-add")).Click();
        }

        public void OpenBoard(string boardName)
        {
            Wait.Until(d => Driver.DriverInstance.FindElements(By.XPath($"//div[@title = '{boardName}']")).Any());

            Driver.DriverInstance.FindElement(By.XPath($"//div[@title = '{boardName}']")).Click();
        }
    }
}
