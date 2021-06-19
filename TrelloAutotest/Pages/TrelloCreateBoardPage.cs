using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    class TrelloCreateBoardPage : BasePage
    {
        public void CreateBoard(string BoardName)
        {
            Wait.Until(d => Driver.DriverInstance.FindElements(By.XPath("//input[@data-test-id='create-board-title-input']")).Any());

            var driver = Driver.DriverInstance;

            driver.FindElement(By.XPath("//input[@data-test-id='create-board-title-input']")).SendKeys(BoardName);
            driver.FindElement(By.XPath("//button[@data-test-id='create-board-submit-button']")).Click();
        }
    }
}
