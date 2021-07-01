using OpenQA.Selenium;
using System.Linq;
using TrelloAutotest.Messages;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using Selectors = Selectors.BoardSelectors;
    using BaseSelectors = Selectors.BaseSelectors;

    public class TrelloBoardPage : BasePage
    {
        public TrelloBoardPage() => Wait.Until(d => driver.FindElements(Selectors.BoardHeader).Any());

        public void OpenBoardMenu() => driver.FindElements(By.TagName("a")).First(x => x.Text.Contains(MessageText.ShowMenu)).Click();
        
        public bool IsLoginCorrect() => driver.FindElements(Selectors.BoardHeader).Any();

        public bool IsUrlCorrect(string BoardName)
        {
            Wait.Until(d => driver.FindElements(Selectors.BoardViewButton).Any());

            var SplitName = BoardName.Contains(' ') ? BoardName.ToLower().Replace(' ', '-').TrimEnd('-') : BoardName.ToLower();
            var url = TrimUrl(driver.Url);

            return url == (SplitName);
        }

        public string TrimUrl(string Url) => Url.Split('/').Last();

        public bool IsBoardCreated() => driver.FindElements(Selectors.BoardViewButton).Any();

        public bool IsBoardMenuAvilable() => driver.FindElements(Selectors.BoardMenu).Any();

        public void DeleteBoard()
        {
            OpenBoardMenu();

            var MenuPanel = driver.FindElement(Selectors.BoardMenu);
            MenuPanel.FindElement(Selectors.BoardMenuMore).Click();
            driver.FindElement(Selectors.BoardCloseBoard).Click();
            driver.FindElement(BaseSelectors.ConfirmButton).Click();
        }
    }
}
