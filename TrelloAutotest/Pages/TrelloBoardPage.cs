using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;
using TrelloAutotest.Messages;
using TrelloAutotest.Selectors;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    public class TrelloBoardPage : BasePage
    {
        public void OpenBoardMenu() => driver.FindElements(By.TagName("a")).First(x => x.Text.Contains(MessageText.ShowMenu)).Click();

        public TrelloBoardPage VerifyUrl(string BoardName)
        {
            Wait.Until(d => driver.FindElements(BoardSelectors.BoardViewButton).Any());

            var splittedName = (BoardName.Contains(' ') ? BoardName.Replace(' ', '-').TrimEnd('-') : BoardName).ToLower();
            var url = GetBoardNameUrl(driver.Url);

            Assert.IsTrue(url == splittedName);
            return this;
        }

        private string GetBoardNameUrl(string Url) => Url.Split('/').Last();

        public TrelloBoardPage VerifyBoardViewButtonExists()
        {
            Assert.IsTrue(driver.FindElements(BoardSelectors.BoardViewButton).Any());

            return this;
        }

        public TrelloBoardPage VerifyBoardViewButtonNotExists()
        {
            Assert.IsFalse(driver.FindElements(BoardSelectors.BoardViewButton).Any());

            return this;
        }

        public TrelloBoardPage VerifyBoardMenuButtonExists()
        {
            Assert.IsTrue(driver.FindElements(BoardSelectors.BoardMenu).Any());

            return this;
        }

        public TrelloBoardPage VerifyBoardMenuButtonNotExists()
        {
            Assert.IsFalse(driver.FindElements(BoardSelectors.BoardMenu).Any());

            return this;
        }

        public TrelloConfirmDeletePage DeleteBoard()
        {
            OpenBoardMenu();

            var MenuPanel = driver.FindElement(BoardSelectors.BoardMenu);
            MenuPanel.FindElement(BoardSelectors.BoardMenuMore).Click();
            driver.FindElement(BoardSelectors.BoardCloseBoard).Click();
            driver.FindElement(BaseSelectors.ConfirmButton).Click();

            return new TrelloConfirmDeletePage();
        }
    }
}
