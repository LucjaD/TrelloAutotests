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

       

        public TrelloBoardPage IsUrlCorrect(string BoardName)
        {
            Wait.Until(d => driver.FindElements(BoardSelectors.BoardViewButton).Any());

            var SplitName = BoardName.Contains(' ') ? BoardName.ToLower().Replace(' ', '-').TrimEnd('-') : BoardName.ToLower();
            var url = TrimUrl(driver.Url);

            Assert.IsTrue(url == (SplitName));
            return this;
        }

        public string TrimUrl(string Url) => Url.Split('/').Last();

        public TrelloBoardPage IsBoardCreated(bool assertFlag)
        {

            if (assertFlag) Assert.IsTrue(driver.FindElements(BoardSelectors.BoardViewButton).Any());
            else Assert.IsFalse(driver.FindElements(BoardSelectors.BoardViewButton).Any());
            return this;
        }

        public TrelloBoardPage IsBoardMenuAvilable(bool assertFlag)
        {
            if (assertFlag) Assert.IsTrue(driver.FindElements(BoardSelectors.BoardMenu).Any());
            else Assert.IsFalse(driver.FindElements(BoardSelectors.BoardMenu).Any());
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
