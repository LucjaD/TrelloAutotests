using OpenQA.Selenium;
using System.Linq;
using TrelloAutotests.Pages;

namespace TrelloAutotest.Pages
{
    using Selectors = Selectors.BoardConst;
    using BaseSelectors = Selectors.BaseConst;

    public class TrelloBoardPage : BasePage
    {
        public TrelloBoardPage() => Wait.Until(d => driver.FindElements(Selectors.BoardHeader).Any());

        public string TrimUrl(string Url) => Url.Split('/').Last();

        public void OpenBoardMenu() => driver.FindElements(By.TagName("a")).First(x => x.Text.Contains("Pokaż menu")).Click();
        
        public bool IsLoginCorrect() => driver.FindElements(Selectors.BoardHeader).Any(); 

        public bool IsUrlCorrect(string BoardName)
        {
            Wait.Until(d => driver.FindElements(By.Id("board")).Any());

            var SplitName = BoardName.Contains(' ') ? BoardName.ToLower().Replace(' ', '-').TrimEnd('-') : BoardName.ToLower();
            var url = TrimUrl(driver.Url);

            return url == (SplitName);
        }

        public void DeleteBoard()
        {
            OpenBoardMenu();

            var tak = driver.FindElement(Selectors.BoardMenu);
            tak.FindElement(Selectors.BoardMenuMore).Click();
            driver.FindElement(Selectors.BoardCloseBoard).Click();
            driver.FindElement(BaseSelectors.ConfirmButton).Click();
        }
    }
}
